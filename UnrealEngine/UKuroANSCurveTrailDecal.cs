using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B2 RID: 1202
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroANSCurveTrailDecal")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroANSCurveTrailDecal : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F18 RID: 28440 RVA: 0x000A4675 File Offset: 0x000A2875
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroANSCurveTrailDecal._ClassPtr;
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x000A4684 File Offset: 0x000A2884
		public UKuroANSCurveTrailDecal() : this(BuiltinUtils.AllocNativeUObject(UKuroANSCurveTrailDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x000A46AC File Offset: 0x000A28AC
		[NullableContext(1)]
		public UKuroANSCurveTrailDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroANSCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06006F1B RID: 28443 RVA: 0x000A46DF File Offset: 0x000A28DF
		// (set) Token: 0x06006F1C RID: 28444 RVA: 0x000A46F3 File Offset: 0x000A28F3
		public unsafe FName AttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachSocketName) = value;
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06006F1D RID: 28445 RVA: 0x000A4708 File Offset: 0x000A2908
		// (set) Token: 0x06006F1E RID: 28446 RVA: 0x000A471C File Offset: 0x000A291C
		public unsafe FTransform AttachTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachTransform) = value;
			}
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x000A4731 File Offset: 0x000A2931
		static UKuroANSCurveTrailDecal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroANSCurveTrailDecal");
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x000A473F File Offset: 0x000A293F
		protected UKuroANSCurveTrailDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003009 RID: 12297
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroANSCurveTrailDecal";

		// Token: 0x0400300A RID: 12298
		private static IntPtr _ClassPtr;

		// Token: 0x0400300B RID: 12299
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400300C RID: 12300
		internal static int __PropertyOffset_AttachSocketName;

		// Token: 0x0400300D RID: 12301
		internal static int __PropertyOffset_AttachTransform;
	}
}
