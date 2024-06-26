Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports TRUONGANHQUAN_2210900058_LESS9

Namespace Controllers
    Public Class TaqKhoasController
        Inherits System.Web.Mvc.Controller

        Private db As New TRUONGANHQUAN_2210900058_LESSION9Entities

        ' GET: TaqKhoas
        Function Index() As ActionResult
            Return View(db.TaqKhoa.ToList())
        End Function

        ' GET: TaqKhoas/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim taqKhoa As TaqKhoa = db.TaqKhoa.Find(id)
            If IsNothing(taqKhoa) Then
                Return HttpNotFound()
            End If
            Return View(taqKhoa)
        End Function

        ' GET: TaqKhoas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TaqKhoas/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="TaqMakhoa,TaqTenkhoa,TaqTrangThai")> ByVal taqKhoa As TaqKhoa) As ActionResult
            If ModelState.IsValid Then
                db.TaqKhoa.Add(taqKhoa)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(taqKhoa)
        End Function

        ' GET: TaqKhoas/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim taqKhoa As TaqKhoa = db.TaqKhoa.Find(id)
            If IsNothing(taqKhoa) Then
                Return HttpNotFound()
            End If
            Return View(taqKhoa)
        End Function

        ' POST: TaqKhoas/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="TaqMakhoa,TaqTenkhoa,TaqTrangThai")> ByVal taqKhoa As TaqKhoa) As ActionResult
            If ModelState.IsValid Then
                db.Entry(taqKhoa).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(taqKhoa)
        End Function

        ' GET: TaqKhoas/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim taqKhoa As TaqKhoa = db.TaqKhoa.Find(id)
            If IsNothing(taqKhoa) Then
                Return HttpNotFound()
            End If
            Return View(taqKhoa)
        End Function

        ' POST: TaqKhoas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim taqKhoa As TaqKhoa = db.TaqKhoa.Find(id)
            db.TaqKhoa.Remove(taqKhoa)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
