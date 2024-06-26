@ModelType TRUONGANHQUAN_2210900058_LESS9.TaqSinhvien
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_TaqLayout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>TaqSinhvien</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqHoSV)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqHoSV)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqTenSV)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqTenSV)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqNgaySinh)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqNgaySinh)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqPhai)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqPhai)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqPhone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqPhone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TaqKhoa.TaqTenkhoa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TaqKhoa.TaqTenkhoa)
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
