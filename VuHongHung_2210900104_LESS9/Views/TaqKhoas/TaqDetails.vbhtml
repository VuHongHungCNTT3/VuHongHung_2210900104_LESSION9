@ModelType TRUONGANHQUAN_2210900058_LESS9.TaqKhoa
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_TaqLayout.vbhtml"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.TaqMakhoa }) |
    @Html.ActionLink("Back to List", "Index")
</p>
