using QLNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNhanVien.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            var listNhanVien = new DBNhanVienContext().NhanViens.ToList();
            return View(listNhanVien);
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            var context = new DBNhanVienContext();
            var chucVuSelect = new SelectList(context.ChucVus,"Id", "TenChucVu");
            ViewBag.IdChucVu = chucVuSelect;
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBNhanVienContext();
                context.NhanViens.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new DBNhanVienContext();
            var editing = context.NhanViens.Find(id);
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu", editing.IdChucVu);
            ViewBag.IdChucVu = chucVuSelect;
            return View(editing);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBNhanVienContext();
                var oldtem = context.NhanViens.Find(model.Id);
                oldtem.HoVaTen = model.HoVaTen;
                oldtem.GioiTinh = model.GioiTinh;
                oldtem.Email = model.Email;
                oldtem.IdChucVu = model.IdChucVu;
                oldtem.SoCanCuoc = model.SoCanCuoc;
                oldtem.SoDienThoai = model.SoDienThoai;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new DBNhanVienContext();
            var deleting = context.NhanViens.Find(id);
            return View(deleting);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new DBNhanVienContext();
                var deleting = context.NhanViens.Find(id);
                context.NhanViens.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
