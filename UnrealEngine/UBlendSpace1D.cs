using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B5 RID: 2229
	[UnrealObjectPath("/Script/Engine.BlendSpace1D")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UBlendSpace1D : UBlendSpaceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079CC RID: 31180 RVA: 0x000AE2F7 File Offset: 0x000AC4F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlendSpace1D._ClassPtr;
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x000AE304 File Offset: 0x000AC504
		public UBlendSpace1D() : this(BuiltinUtils.AllocNativeUObject(UBlendSpace1D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x000AE32C File Offset: 0x000AC52C
		[NullableContext(1)]
		public UBlendSpace1D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlendSpace1D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x060079CF RID: 31183 RVA: 0x000AE35F File Offset: 0x000AC55F
		// (set) Token: 0x060079D0 RID: 31184 RVA: 0x000AE36F File Offset: 0x000AC56F
		public unsafe bool bScaleAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlendSpace1D.__PropertyOffset_bScaleAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlendSpace1D.__PropertyOffset_bScaleAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x000AE380 File Offset: 0x000AC580
		static UBlendSpace1D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlendSpace1D");
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x000AE38E File Offset: 0x000AC58E
		protected UBlendSpace1D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A84 RID: 14980
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlendSpace1D";

		// Token: 0x04003A85 RID: 14981
		private static IntPtr _ClassPtr;

		// Token: 0x04003A86 RID: 14982
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A87 RID: 14983
		internal static int __PropertyOffset_bScaleAnimation;
	}
}
