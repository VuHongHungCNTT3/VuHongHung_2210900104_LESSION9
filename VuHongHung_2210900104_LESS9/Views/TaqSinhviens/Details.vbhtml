@ModelType TRUONGANHQUAN_2210900058_LESS9.TaqSinhvien
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_TaqLayout.vbhtml"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.TaqMaSV }) |
    @Html.ActionLink("Back to List", "Index")
</p>
