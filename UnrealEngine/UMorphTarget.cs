using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EB7 RID: 3767
	[UnrealObjectPath("/Script/Engine.MorphTarget")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UMorphTarget : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CBDB RID: 52187 RVA: 0x001291EE File Offset: 0x001273EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMorphTarget._ClassPtr;
		}

		// Token: 0x0600CBDC RID: 52188 RVA: 0x001291FC File Offset: 0x001273FC
		public UMorphTarget() : this(BuiltinUtils.AllocNativeUObject(UMorphTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CBDD RID: 52189 RVA: 0x00129224 File Offset: 0x00127424
		[NullableContext(1)]
		public UMorphTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMorphTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x0600CBDE RID: 52190 RVA: 0x00129257 File Offset: 0x00127457
		// (set) Token: 0x0600CBDF RID: 52191 RVA: 0x0012926B File Offset: 0x0012746B
		[Nullable(2)]
		public unsafe USkeletalMesh BaseSkelMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UMorphTarget.__PropertyOffset_BaseSkelMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMorphTarget.__PropertyOffset_BaseSkelMesh, value);
			}
		}

		// Token: 0x0600CBE0 RID: 52192 RVA: 0x00129280 File Offset: 0x00127480
		static UMorphTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MorphTarget");
		}

		// Token: 0x0600CBE1 RID: 52193 RVA: 0x0012928E File Offset: 0x0012748E
		protected UMorphTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006DD7 RID: 28119
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MorphTarget";

		// Token: 0x04006DD8 RID: 28120
		private static IntPtr _ClassPtr;

		// Token: 0x04006DD9 RID: 28121
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006DDA RID: 28122
		internal static int __PropertyOffset_BaseSkelMesh;
	}
}
