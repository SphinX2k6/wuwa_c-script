using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D7 RID: 8663
	[UnrealObjectPath("/Script/LGUI.UITextureBox")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class UUITextureBox : UUITextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021043 RID: 135235 RVA: 0x0030B525 File Offset: 0x00309725
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextureBox._ClassPtr;
		}

		// Token: 0x06021044 RID: 135236 RVA: 0x0030B534 File Offset: 0x00309734
		public UUITextureBox() : this(BuiltinUtils.AllocNativeUObject(UUITextureBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021045 RID: 135237 RVA: 0x0030B55C File Offset: 0x0030975C
		[NullableContext(1)]
		public UUITextureBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextureBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080E0 RID: 32992
		// (get) Token: 0x06021046 RID: 135238 RVA: 0x0030B58F File Offset: 0x0030978F
		// (set) Token: 0x06021047 RID: 135239 RVA: 0x0030B59F File Offset: 0x0030979F
		public unsafe float thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextureBox.__PropertyOffset_thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextureBox.__PropertyOffset_thickness) = value;
			}
		}

		// Token: 0x170080E1 RID: 32993
		// (get) Token: 0x06021048 RID: 135240 RVA: 0x0030B5B0 File Offset: 0x003097B0
		// (set) Token: 0x06021049 RID: 135241 RVA: 0x0030B5C0 File Offset: 0x003097C0
		public unsafe bool seperateFrontColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextureBox.__PropertyOffset_seperateFrontColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextureBox.__PropertyOffset_seperateFrontColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170080E2 RID: 32994
		// (get) Token: 0x0602104A RID: 135242 RVA: 0x0030B5D1 File Offset: 0x003097D1
		// (set) Token: 0x0602104B RID: 135243 RVA: 0x0030B5E5 File Offset: 0x003097E5
		public unsafe FColor frontFaceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextureBox.__PropertyOffset_frontFaceColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextureBox.__PropertyOffset_frontFaceColor) = value;
			}
		}

		// Token: 0x0602104C RID: 135244 RVA: 0x0030B5FA File Offset: 0x003097FA
		static UUITextureBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureBox");
		}

		// Token: 0x0602104D RID: 135245 RVA: 0x0030B608 File Offset: 0x00309808
		protected UUITextureBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119E3 RID: 72163
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureBox";

		// Token: 0x040119E4 RID: 72164
		private static IntPtr _ClassPtr;

		// Token: 0x040119E5 RID: 72165
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119E6 RID: 72166
		internal static int __PropertyOffset_thickness;

		// Token: 0x040119E7 RID: 72167
		internal static int __PropertyOffset_seperateFrontColor;

		// Token: 0x040119E8 RID: 72168
		internal static int __PropertyOffset_frontFaceColor;
	}
}
