using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200219F RID: 8607
	[UnrealObjectPath("/Script/LGUI.UIRoundedLayout")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UUIRoundedLayout : UUILayoutBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A50 RID: 133712 RVA: 0x00304EF3 File Offset: 0x003030F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIRoundedLayout._ClassPtr;
		}

		// Token: 0x06020A51 RID: 133713 RVA: 0x00304F00 File Offset: 0x00303100
		public UUIRoundedLayout() : this(BuiltinUtils.AllocNativeUObject(UUIRoundedLayout.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A52 RID: 133714 RVA: 0x00304F28 File Offset: 0x00303128
		[NullableContext(1)]
		public UUIRoundedLayout(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIRoundedLayout.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F98 RID: 32664
		// (get) Token: 0x06020A53 RID: 133715 RVA: 0x00304F5B File Offset: 0x0030315B
		// (set) Token: 0x06020A54 RID: 133716 RVA: 0x00304F6B File Offset: 0x0030316B
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17007F99 RID: 32665
		// (get) Token: 0x06020A55 RID: 133717 RVA: 0x00304F7C File Offset: 0x0030317C
		// (set) Token: 0x06020A56 RID: 133718 RVA: 0x00304F8C File Offset: 0x0030318C
		public unsafe float StartAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_StartAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_StartAngle) = value;
			}
		}

		// Token: 0x17007F9A RID: 32666
		// (get) Token: 0x06020A57 RID: 133719 RVA: 0x00304F9D File Offset: 0x0030319D
		// (set) Token: 0x06020A58 RID: 133720 RVA: 0x00304FAD File Offset: 0x003031AD
		public unsafe float EndAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_EndAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_EndAngle) = value;
			}
		}

		// Token: 0x17007F9B RID: 32667
		// (get) Token: 0x06020A59 RID: 133721 RVA: 0x00304FBE File Offset: 0x003031BE
		// (set) Token: 0x06020A5A RID: 133722 RVA: 0x00304FCE File Offset: 0x003031CE
		public unsafe bool bSetChildAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_bSetChildAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRoundedLayout.__PropertyOffset_bSetChildAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020A5B RID: 133723 RVA: 0x00304FDF File Offset: 0x003031DF
		static UUIRoundedLayout()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIRoundedLayout");
		}

		// Token: 0x06020A5C RID: 133724 RVA: 0x00304FED File Offset: 0x003031ED
		protected UUIRoundedLayout(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011779 RID: 71545
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIRoundedLayout";

		// Token: 0x0401177A RID: 71546
		private static IntPtr _ClassPtr;

		// Token: 0x0401177B RID: 71547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401177C RID: 71548
		internal static int __PropertyOffset_Radius;

		// Token: 0x0401177D RID: 71549
		internal static int __PropertyOffset_StartAngle;

		// Token: 0x0401177E RID: 71550
		internal static int __PropertyOffset_EndAngle;

		// Token: 0x0401177F RID: 71551
		internal static int __PropertyOffset_bSetChildAngle;
	}
}
