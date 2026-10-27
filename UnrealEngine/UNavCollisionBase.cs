using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000ED3 RID: 3795
	[UnrealObjectPath("/Script/Engine.NavCollisionBase")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public abstract class UNavCollisionBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CD9E RID: 52638 RVA: 0x0012BC40 File Offset: 0x00129E40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavCollisionBase._ClassPtr;
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0600CD9F RID: 52639 RVA: 0x0012BC4C File Offset: 0x00129E4C
		// (set) Token: 0x0600CDA0 RID: 52640 RVA: 0x0012BC65 File Offset: 0x00129E65
		public unsafe bool bIsDynamicObstacle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavCollisionBase.__PropertyOffset_bIsDynamicObstacle) & UNavCollisionBase.__PropertyMask_bIsDynamicObstacle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavCollisionBase.__PropertyOffset_bIsDynamicObstacle) = ((*(base.NativePtr + (IntPtr)UNavCollisionBase.__PropertyOffset_bIsDynamicObstacle) & ~UNavCollisionBase.__PropertyMask_bIsDynamicObstacle) | (value ? UNavCollisionBase.__PropertyMask_bIsDynamicObstacle : 0));
			}
		}

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x0012BC95 File Offset: 0x00129E95
		static UNavCollisionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavCollisionBase");
		}

		// Token: 0x0600CDA2 RID: 52642 RVA: 0x0012BCA4 File Offset: 0x00129EA4
		protected UNavCollisionBase() : this(BuiltinUtils.AllocNativeUObject(UNavCollisionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CDA3 RID: 52643 RVA: 0x0012BCCC File Offset: 0x00129ECC
		protected UNavCollisionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006EC8 RID: 28360
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavCollisionBase";

		// Token: 0x04006EC9 RID: 28361
		private static IntPtr _ClassPtr;

		// Token: 0x04006ECA RID: 28362
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006ECB RID: 28363
		internal static int __PropertyOffset_bIsDynamicObstacle;

		// Token: 0x04006ECC RID: 28364
		internal static byte __PropertyMask_bIsDynamicObstacle;
	}
}
