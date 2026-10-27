using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010FB RID: 4347
	[UnrealObjectPath("/Script/Engine.SkeletalMeshEditorData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class USkeletalMeshEditorData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FC24 RID: 64548 RVA: 0x00174259 File Offset: 0x00172459
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMeshEditorData._ClassPtr;
		}

		// Token: 0x0600FC25 RID: 64549 RVA: 0x00174268 File Offset: 0x00172468
		public USkeletalMeshEditorData() : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshEditorData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FC26 RID: 64550 RVA: 0x00174290 File Offset: 0x00172490
		[NullableContext(1)]
		public USkeletalMeshEditorData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshEditorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600FC27 RID: 64551 RVA: 0x001742C3 File Offset: 0x001724C3
		static USkeletalMeshEditorData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshEditorData");
		}

		// Token: 0x0600FC28 RID: 64552 RVA: 0x001742D1 File Offset: 0x001724D1
		protected USkeletalMeshEditorData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040087CE RID: 34766
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshEditorData";

		// Token: 0x040087CF RID: 34767
		private static IntPtr _ClassPtr;

		// Token: 0x040087D0 RID: 34768
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
