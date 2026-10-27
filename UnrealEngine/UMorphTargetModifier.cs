using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EB8 RID: 3768
	[UnrealObjectPath("/Script/Engine.MorphTargetModifier")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UMorphTargetModifier : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CBE2 RID: 52194 RVA: 0x00129297 File Offset: 0x00127497
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMorphTargetModifier._ClassPtr;
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x0600CBE3 RID: 52195 RVA: 0x001292A3 File Offset: 0x001274A3
		// (set) Token: 0x0600CBE4 RID: 52196 RVA: 0x001292B7 File Offset: 0x001274B7
		[Nullable(2)]
		public unsafe UWorld WorldContext
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UMorphTargetModifier.__PropertyOffset_WorldContext);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMorphTargetModifier.__PropertyOffset_WorldContext, value);
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x0600CBE5 RID: 52197 RVA: 0x001292CC File Offset: 0x001274CC
		// (set) Token: 0x0600CBE6 RID: 52198 RVA: 0x001292E0 File Offset: 0x001274E0
		public unsafe FVector CameraLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMorphTargetModifier.__PropertyOffset_CameraLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMorphTargetModifier.__PropertyOffset_CameraLocation) = value;
			}
		}

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x001292F5 File Offset: 0x001274F5
		static UMorphTargetModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MorphTargetModifier");
		}

		// Token: 0x0600CBE8 RID: 52200 RVA: 0x00129304 File Offset: 0x00127504
		protected UMorphTargetModifier() : this(BuiltinUtils.AllocNativeUObject(UMorphTargetModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CBE9 RID: 52201 RVA: 0x0012932C File Offset: 0x0012752C
		protected UMorphTargetModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DDB RID: 28123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MorphTargetModifier";

		// Token: 0x04006DDC RID: 28124
		private static IntPtr _ClassPtr;

		// Token: 0x04006DDD RID: 28125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006DDE RID: 28126
		internal static int __PropertyOffset_WorldContext;

		// Token: 0x04006DDF RID: 28127
		internal static int __PropertyOffset_CameraLocation;
	}
}
