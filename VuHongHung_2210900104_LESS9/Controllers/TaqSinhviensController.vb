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
    Public Class TaqSinhviensController
        Inherits System.Web.Mvc.Controller

        Private db As New TRUONGANHQUAN_2210900058_LESSION9Entities

        ' GET: TaqSinhviens
        Function Index() As ActionResult
            Dim taqSinhvien = db.TaqSinhvien.Include(Function(t) t.TaqKhoa)
            Return View(taqSinhvien.ToList())
        End Function

        ' GET: TaqSinhviens/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim taqSinhvien As TaqSinhvien = db.TaqSinhvien.Find(id)
            If IsNothing(taqSinhvien) Then
                Return HttpNotFound()
            End If
            Return View(taqSinhvien)
        End Function

        ' GET: TaqSinhviens/Create
        Function Create() As ActionResult
            ViewBag.TaqMakhoa = New SelectList(db.TaqKhoa, "TaqMakhoa", "TaqTenkhoa")
            Return View()
        End Function

        ' POST: TaqSinhviens/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="TaqMaSV,TaqHoSV,TaqTenSV,TaqNgaySinh,TaqPhai,TaqPhone,TaqEmail,TaqMakhoa")> ByVal taqSinhvien As TaqSinhvien) As ActionResult
            If ModelState.IsValid Then
                db.TaqSinhvien.Add(taqSinhvien)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.TaqMakhoa = New SelectList(db.TaqKhoa, "TaqMakhoa", "TaqTenkhoa", taqSinhvien.TaqMakhoa)
            Return View(taqSinhvien)
        End Function

        ' GET: TaqSinhviens/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim taqSinhvien As TaqSinhvien = db.TaqSinhvien.Find(id)
            If IsNothing(taqSinhvien) Then
                Return HttpNotFound()
            End If
            ViewBag.TaqMakhoa = New SelectList(db.TaqKhoa, "TaqMakhoa", "TaqTenkhoa", taqSinhvien.TaqMakhoa)
            Return View(taqSinhvien)
        End Function

        ' POST: TaqSinhviens/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="TaqMaSV,TaqHoSV,TaqTenSV,TaqNgaySinh,TaqPhai,TaqPhone,TaqEmail,TaqMakhoa")> ByVal taqSinhvien As TaqSinhvien) As ActionResult
            If ModelState.IsValid Then
                db.Entry(taqSinhvien).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.TaqMakhoa = New SelectList(db.TaqKhoa, "TaqMakhoa", "TaqTenkhoa", taqSinhvien.TaqMakhoa)
            Return View(taqSinhvien)
        End Function

        ' GET: TaqSinhviens/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim taqSinhvien As TaqSinhvien = db.TaqSinhvien.Find(id)
            If IsNothing(taqSinhvien) Then
                Return HttpNotFound()
            End If
            Return View(taqSinhvien)
        End Function

        ' POST: TaqSinhviens/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim taqSinhvien As TaqSinhvien = db.TaqSinhvien.Find(id)
            db.TaqSinhvien.Remove(taqSinhvien)
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
