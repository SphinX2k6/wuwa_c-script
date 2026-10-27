using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EBA RID: 3770
	[UnrealObjectPath("/Script/Engine.MorphTargetModifier_CameraAdapter")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UMorphTargetModifier_CameraAdapter : UMorphTargetModifier, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CBF7 RID: 52215 RVA: 0x001294DE File Offset: 0x001276DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMorphTargetModifier_CameraAdapter._ClassPtr;
		}

		// Token: 0x0600CBF8 RID: 52216 RVA: 0x001294EC File Offset: 0x001276EC
		public UMorphTargetModifier_CameraAdapter() : this(BuiltinUtils.AllocNativeUObject(UMorphTargetModifier_CameraAdapter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x00129514 File Offset: 0x00127714
		[NullableContext(1)]
		public UMorphTargetModifier_CameraAdapter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMorphTargetModifier_CameraAdapter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x00129547 File Offset: 0x00127747
		static UMorphTargetModifier_CameraAdapter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MorphTargetModifier_CameraAdapter");
		}

		// Token: 0x0600CBFB RID: 52219 RVA: 0x00129555 File Offset: 0x00127755
		protected UMorphTargetModifier_CameraAdapter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DEA RID: 28138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MorphTargetModifier_CameraAdapter";

		// Token: 0x04006DEB RID: 28139
		private static IntPtr _ClassPtr;

		// Token: 0x04006DEC RID: 28140
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
