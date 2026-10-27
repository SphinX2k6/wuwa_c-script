using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B4 RID: 2228
	[UnrealObjectPath("/Script/Engine.BlendSpace")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UBlendSpace : UBlendSpaceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079C5 RID: 31173 RVA: 0x000AE24E File Offset: 0x000AC44E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlendSpace._ClassPtr;
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x000AE25C File Offset: 0x000AC45C
		public UBlendSpace() : this(BuiltinUtils.AllocNativeUObject(UBlendSpace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x000AE284 File Offset: 0x000AC484
		[NullableContext(1)]
		public UBlendSpace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlendSpace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x060079C8 RID: 31176 RVA: 0x000AE2B7 File Offset: 0x000AC4B7
		// (set) Token: 0x060079C9 RID: 31177 RVA: 0x000AE2CB File Offset: 0x000AC4CB
		public unsafe TEnumAsByte<EBlendSpaceAxis> AxisToScaleAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlendSpace.__PropertyOffset_AxisToScaleAnimation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlendSpace.__PropertyOffset_AxisToScaleAnimation) = value;
			}
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x000AE2E0 File Offset: 0x000AC4E0
		static UBlendSpace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlendSpace");
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x000AE2EE File Offset: 0x000AC4EE
		protected UBlendSpace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A80 RID: 14976
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlendSpace";

		// Token: 0x04003A81 RID: 14977
		private static IntPtr _ClassPtr;

		// Token: 0x04003A82 RID: 14978
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A83 RID: 14979
		internal static int __PropertyOffset_AxisToScaleAnimation;
	}
}
