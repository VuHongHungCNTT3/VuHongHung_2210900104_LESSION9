@ModelType IEnumerable(Of TRUONGANHQUAN_2210900058_LESS9.TaqSinhvien)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_TaqLayout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqHoSV)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqTenSV)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqNgaySinh)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqPhai)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqPhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqEmail)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqKhoa.TaqTenkhoa)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqHoSV)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqTenSV)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqNgaySinh)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqPhai)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqPhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqEmail)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqKhoa.TaqTenkhoa)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.TaqMaSV }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.TaqMaSV }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.TaqMaSV })
        </td>
    </tr>
Next

</table>
