using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace TailwindWPF.Styling.Styles
{
    public class BorderStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Border Width
            ["border-0"] = d => SetThickness(d, 0),
            ["border"] = d => SetThickness(d, 1),
            ["border-2"] = d => SetThickness(d, 2),
            ["border-4"] = d => SetThickness(d, 4),
            ["border-8"] = d => SetThickness(d, 8),

            // Border Colors
            ["border-transparent"] = SetBorderBrush(Brushes.Transparent),
            ["border-current"] = d =>
            {
                if (d is Control c) c.BorderBrush = c.Foreground;
                else if (d is Border b) b.BorderBrush = Brushes.Black;
            },
            ["border-black"] = SetBorderBrush(Brushes.Black),
            ["border-white"] = SetBorderBrush(Brushes.White),

            // Gray Border 
            ["border-gray-50"] = SetBorderBrush(CreateBrush("#F9FAFB")),
            ["border-gray-100"] = SetBorderBrush(CreateBrush("#F3F4F6")),
            ["border-gray-200"] = SetBorderBrush(CreateBrush("#E5E7EB")),
            ["border-gray-300"] = SetBorderBrush(CreateBrush("#D1D5DB")),
            ["border-gray-400"] = SetBorderBrush(CreateBrush("#9CA3AF")),
            ["border-gray-500"] = SetBorderBrush(CreateBrush("#6B7280")),

            // Yellow Border
            ["border-yellow-50"] = SetBorderBrush(CreateBrush("#FFFBEB")),
            ["border-yellow-100"] = SetBorderBrush(CreateBrush("#FEF3C7")),
            ["border-yellow-200"] = SetBorderBrush(CreateBrush("#FDE68A")),
            ["border-yellow-300"] = SetBorderBrush(CreateBrush("#FCD34D")),
            ["border-yellow-400"] = SetBorderBrush(CreateBrush("#FBBF24")),
            ["border-yellow-500"] = SetBorderBrush(CreateBrush("#F59E0B")),
            ["border-yellow-600"] = SetBorderBrush(CreateBrush("#D97706")),
            ["border-yellow-700"] = SetBorderBrush(CreateBrush("#B45309")),
            ["border-yellow-800"] = SetBorderBrush(CreateBrush("#92400E")),
            ["border-yellow-900"] = SetBorderBrush(CreateBrush("#78350F")),

            // Purple Border
            ["border-purple-50"] = SetBorderBrush(CreateBrush("#FAF5FF")),
            ["border-purple-100"] = SetBorderBrush(CreateBrush("#F3E8FF")),
            ["border-purple-200"] = SetBorderBrush(CreateBrush("#E9D5FF")),
            ["border-purple-300"] = SetBorderBrush(CreateBrush("#D8B4FE")),
            ["border-purple-400"] = SetBorderBrush(CreateBrush("#C084FC")),
            ["border-purple-500"] = SetBorderBrush(CreateBrush("#A855F7")),
            ["border-purple-600"] = SetBorderBrush(CreateBrush("#9333EA")),
            ["border-purple-700"] = SetBorderBrush(CreateBrush("#7C3AED")),
            ["border-purple-800"] = SetBorderBrush(CreateBrush("#6B21A8")),
            ["border-purple-900"] = SetBorderBrush(CreateBrush("#581C87")),

            // Pink Border
            ["border-pink-50"] = SetBorderBrush(CreateBrush("#FDF2F8")),
            ["border-pink-100"] = SetBorderBrush(CreateBrush("#FCE7F3")),
            ["border-pink-200"] = SetBorderBrush(CreateBrush("#FBCFE8")),
            ["border-pink-300"] = SetBorderBrush(CreateBrush("#F9A8D4")),
            ["border-pink-400"] = SetBorderBrush(CreateBrush("#F472B6")),
            ["border-pink-500"] = SetBorderBrush(CreateBrush("#EC4899")),
            ["border-pink-600"] = SetBorderBrush(CreateBrush("#DB2777")),
            ["border-pink-700"] = SetBorderBrush(CreateBrush("#BE185D")),
            ["border-pink-800"] = SetBorderBrush(CreateBrush("#9D174D")),
            ["border-pink-900"] = SetBorderBrush(CreateBrush("#831843")),

            // Indigo Border
            ["border-indigo-50"] = SetBorderBrush(CreateBrush("#EEF2FF")),
            ["border-indigo-100"] = SetBorderBrush(CreateBrush("#E0E7FF")),
            ["border-indigo-200"] = SetBorderBrush(CreateBrush("#C7D2FE")),
            ["border-indigo-300"] = SetBorderBrush(CreateBrush("#A5B4FC")),
            ["border-indigo-400"] = SetBorderBrush(CreateBrush("#818CF8")),
            ["border-indigo-500"] = SetBorderBrush(CreateBrush("#6366F1")),
            ["border-indigo-600"] = SetBorderBrush(CreateBrush("#4F46E5")),
            ["border-indigo-700"] = SetBorderBrush(CreateBrush("#4338CA")),
            ["border-indigo-800"] = SetBorderBrush(CreateBrush("#3730A3")),
            ["border-indigo-900"] = SetBorderBrush(CreateBrush("#312E81")),

            // Orange Border
            ["border-orange-50"] = SetBorderBrush(CreateBrush("#FFF7ED")),
            ["border-orange-100"] = SetBorderBrush(CreateBrush("#FFEDD5")),
            ["border-orange-200"] = SetBorderBrush(CreateBrush("#FED7AA")),
            ["border-orange-300"] = SetBorderBrush(CreateBrush("#FDBA74")),
            ["border-orange-400"] = SetBorderBrush(CreateBrush("#FB923C")),
            ["border-orange-500"] = SetBorderBrush(CreateBrush("#F97316")),
            ["border-orange-600"] = SetBorderBrush(CreateBrush("#EA580C")),
            ["border-orange-700"] = SetBorderBrush(CreateBrush("#C2410C")),
            ["border-orange-800"] = SetBorderBrush(CreateBrush("#9A3412")),
            ["border-orange-900"] = SetBorderBrush(CreateBrush("#7C2D12")),

            // Teal Border
            ["border-teal-50"] = SetBorderBrush(CreateBrush("#F0FDFA")),
            ["border-teal-100"] = SetBorderBrush(CreateBrush("#CCFBF1")),
            ["border-teal-200"] = SetBorderBrush(CreateBrush("#99F6E4")),
            ["border-teal-300"] = SetBorderBrush(CreateBrush("#5EEAD4")),
            ["border-teal-400"] = SetBorderBrush(CreateBrush("#2DD4BF")),
            ["border-teal-500"] = SetBorderBrush(CreateBrush("#14B8A6")),
            ["border-teal-600"] = SetBorderBrush(CreateBrush("#0D9488")),
            ["border-teal-700"] = SetBorderBrush(CreateBrush("#0F766E")),
            ["border-teal-800"] = SetBorderBrush(CreateBrush("#115E59")),
            ["border-teal-900"] = SetBorderBrush(CreateBrush("#134E4A")),

            // Cyan Border
            ["border-cyan-50"] = SetBorderBrush(CreateBrush("#ECFEFF")),
            ["border-cyan-100"] = SetBorderBrush(CreateBrush("#CFFAFE")),
            ["border-cyan-200"] = SetBorderBrush(CreateBrush("#A5F3FC")),
            ["border-cyan-300"] = SetBorderBrush(CreateBrush("#67E8F9")),
            ["border-cyan-400"] = SetBorderBrush(CreateBrush("#22D3EE")),
            ["border-cyan-500"] = SetBorderBrush(CreateBrush("#06B6D4")),
            ["border-cyan-600"] = SetBorderBrush(CreateBrush("#0891B2")),
            ["border-cyan-700"] = SetBorderBrush(CreateBrush("#0E7490")),
            ["border-cyan-800"] = SetBorderBrush(CreateBrush("#155E75")),
            ["border-cyan-900"] = SetBorderBrush(CreateBrush("#164E63")),

            // Emerald Border
            ["border-emerald-50"] = SetBorderBrush(CreateBrush("#ECFDF5")),
            ["border-emerald-100"] = SetBorderBrush(CreateBrush("#D1FAE5")),
            ["border-emerald-200"] = SetBorderBrush(CreateBrush("#A7F3D0")),
            ["border-emerald-300"] = SetBorderBrush(CreateBrush("#6EE7B7")),
            ["border-emerald-400"] = SetBorderBrush(CreateBrush("#34D399")),
            ["border-emerald-500"] = SetBorderBrush(CreateBrush("#10B981")),
            ["border-emerald-600"] = SetBorderBrush(CreateBrush("#059669")),
            ["border-emerald-700"] = SetBorderBrush(CreateBrush("#047857")),
            ["border-emerald-800"] = SetBorderBrush(CreateBrush("#065F46")),
            ["border-emerald-900"] = SetBorderBrush(CreateBrush("#064E3B")),

            // Lime Border
            ["border-lime-50"] = SetBorderBrush(CreateBrush("#F7FEE7")),
            ["border-lime-100"] = SetBorderBrush(CreateBrush("#ECFCCB")),
            ["border-lime-200"] = SetBorderBrush(CreateBrush("#D9F99D")),
            ["border-lime-300"] = SetBorderBrush(CreateBrush("#BEF264")),
            ["border-lime-400"] = SetBorderBrush(CreateBrush("#A3E635")),
            ["border-lime-500"] = SetBorderBrush(CreateBrush("#84CC16")),
            ["border-lime-600"] = SetBorderBrush(CreateBrush("#65A30D")),
            ["border-lime-700"] = SetBorderBrush(CreateBrush("#4D7C0F")),
            ["border-lime-800"] = SetBorderBrush(CreateBrush("#365314")),
            ["border-lime-900"] = SetBorderBrush(CreateBrush("#1A2E05")),

            // Rose Border
            ["border-rose-50"] = SetBorderBrush(CreateBrush("#FFF1F2")),
            ["border-rose-100"] = SetBorderBrush(CreateBrush("#FFE4E6")),
            ["border-rose-200"] = SetBorderBrush(CreateBrush("#FECDD3")),
            ["border-rose-300"] = SetBorderBrush(CreateBrush("#FDA4AF")),
            ["border-rose-400"] = SetBorderBrush(CreateBrush("#FB7185")),
            ["border-rose-500"] = SetBorderBrush(CreateBrush("#F43F5E")),
            ["border-rose-600"] = SetBorderBrush(CreateBrush("#E11D48")),
            ["border-rose-700"] = SetBorderBrush(CreateBrush("#BE123C")),
            ["border-rose-800"] = SetBorderBrush(CreateBrush("#9F1239")),
            ["border-rose-900"] = SetBorderBrush(CreateBrush("#881337")),

            // Slate Border
            ["border-slate-50"] = SetBorderBrush(CreateBrush("#F8FAFC")),
            ["border-slate-100"] = SetBorderBrush(CreateBrush("#F1F5F9")),
            ["border-slate-200"] = SetBorderBrush(CreateBrush("#E2E8F0")),
            ["border-slate-300"] = SetBorderBrush(CreateBrush("#CBD5E1")),
            ["border-slate-400"] = SetBorderBrush(CreateBrush("#94A3B8")),
            ["border-slate-500"] = SetBorderBrush(CreateBrush("#64748B")),
            ["border-slate-600"] = SetBorderBrush(CreateBrush("#475569")),
            ["border-slate-700"] = SetBorderBrush(CreateBrush("#334155")),
            ["border-slate-800"] = SetBorderBrush(CreateBrush("#1E293B")),
            ["border-slate-900"] = SetBorderBrush(CreateBrush("#0F172A")),

            // Sky Border
            ["border-sky-50"] = SetBorderBrush(CreateBrush("#F0F9FF")),
            ["border-sky-100"] = SetBorderBrush(CreateBrush("#E0F2FE")),
            ["border-sky-200"] = SetBorderBrush(CreateBrush("#BAE6FD")),
            ["border-sky-300"] = SetBorderBrush(CreateBrush("#7DD3FC")),
            ["border-sky-400"] = SetBorderBrush(CreateBrush("#38BDF8")),
            ["border-sky-500"] = SetBorderBrush(CreateBrush("#0EA5E9")),
            ["border-sky-600"] = SetBorderBrush(CreateBrush("#0284C7")),
            ["border-sky-700"] = SetBorderBrush(CreateBrush("#0369A1")),
            ["border-sky-800"] = SetBorderBrush(CreateBrush("#075985")),
            ["border-sky-900"] = SetBorderBrush(CreateBrush("#0C4A6E")),

            // Violet Border
            ["border-violet-50"] = SetBorderBrush(CreateBrush("#F5F3FF")),
            ["border-violet-100"] = SetBorderBrush(CreateBrush("#EDE9FE")),
            ["border-violet-200"] = SetBorderBrush(CreateBrush("#DDD6FE")),
            ["border-violet-300"] = SetBorderBrush(CreateBrush("#C4B5FD")),
            ["border-violet-400"] = SetBorderBrush(CreateBrush("#A78BFA")),
            ["border-violet-500"] = SetBorderBrush(CreateBrush("#8B5CF6")),
            ["border-violet-600"] = SetBorderBrush(CreateBrush("#7C3AED")),
            ["border-violet-700"] = SetBorderBrush(CreateBrush("#6D28D9")),
            ["border-violet-800"] = SetBorderBrush(CreateBrush("#5B21B6")),
            ["border-violet-900"] = SetBorderBrush(CreateBrush("#4C1D95")),

            // Fuchsia Border
            ["border-fuchsia-50"] = SetBorderBrush(CreateBrush("#FDF4FF")),
            ["border-fuchsia-100"] = SetBorderBrush(CreateBrush("#FAE8FF")),
            ["border-fuchsia-200"] = SetBorderBrush(CreateBrush("#F5D0FE")),
            ["border-fuchsia-300"] = SetBorderBrush(CreateBrush("#F0ABFC")),
            ["border-fuchsia-400"] = SetBorderBrush(CreateBrush("#E879F9")),
            ["border-fuchsia-500"] = SetBorderBrush(CreateBrush("#D946EF")),
            ["border-fuchsia-600"] = SetBorderBrush(CreateBrush("#C026D3")),
            ["border-fuchsia-700"] = SetBorderBrush(CreateBrush("#A21CAF")),
            ["border-fuchsia-800"] = SetBorderBrush(CreateBrush("#86198F")),
            ["border-fuchsia-900"] = SetBorderBrush(CreateBrush("#701A75")),

            // Amber Border
            ["border-amber-50"] = SetBorderBrush(CreateBrush("#FFFBEB")),
            ["border-amber-100"] = SetBorderBrush(CreateBrush("#FEF3C7")),
            ["border-amber-200"] = SetBorderBrush(CreateBrush("#FDE68A")),
            ["border-amber-300"] = SetBorderBrush(CreateBrush("#FCD34D")),
            ["border-amber-400"] = SetBorderBrush(CreateBrush("#FBBF24")),
            ["border-amber-500"] = SetBorderBrush(CreateBrush("#F59E0B")),
            ["border-amber-600"] = SetBorderBrush(CreateBrush("#D97706")),
            ["border-amber-700"] = SetBorderBrush(CreateBrush("#B45309")),
            ["border-amber-800"] = SetBorderBrush(CreateBrush("#92400E")),
            ["border-amber-900"] = SetBorderBrush(CreateBrush("#78350F")),

            // Rounded corners
            ["rounded-none"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(0)),
            ["rounded-sm"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(2)),
            ["rounded"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(4)),
            ["rounded-md"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(6)),
            ["rounded-lg"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(8)),
            ["rounded-xl"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(12)),
            ["rounded-2xl"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(16)),
            ["rounded-3xl"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(24)),
            ["rounded-full"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(9999)),
        };

        private static void SetThickness(DependencyObject d, double value)
        {
            var thickness = new Thickness(value);
            if (d is Control c) c.BorderThickness = thickness;
            else if (d is Border b) b.BorderThickness = thickness;
        }

        private static Action<DependencyObject> SetBorderBrush(Brush brush) =>
            d =>
            {
                if (d is Control c) c.BorderBrush = brush;
                else if (d is Border b) b.BorderBrush = brush;
            };
    }

}
