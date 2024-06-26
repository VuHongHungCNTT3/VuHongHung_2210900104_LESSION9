@ModelType TRUONGANHQUAN_2210900058_LESS9.TaqKhoa
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_TaqLayout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>TaqKhoa</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqTenkhoa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqTenkhoa)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqTrangThai)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqTrangThai)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
