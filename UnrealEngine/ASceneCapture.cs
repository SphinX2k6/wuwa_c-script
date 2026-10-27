using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010D1 RID: 4305
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SceneCapture")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public abstract class ASceneCapture : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F594 RID: 62868 RVA: 0x0016BF16 File Offset: 0x0016A116
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASceneCapture._ClassPtr;
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0600F595 RID: 62869 RVA: 0x0016BF22 File Offset: 0x0016A122
		// (set) Token: 0x0600F596 RID: 62870 RVA: 0x0016BF36 File Offset: 0x0016A136
		public unsafe UStaticMeshComponent MeshComp_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCapture.__PropertyOffset_MeshComp_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCapture.__PropertyOffset_MeshComp_DEPRECATED, value);
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0600F597 RID: 62871 RVA: 0x0016BF4B File Offset: 0x0016A14B
		// (set) Token: 0x0600F598 RID: 62872 RVA: 0x0016BF5F File Offset: 0x0016A15F
		public unsafe USceneComponent SceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCapture.__PropertyOffset_SceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASceneCapture.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x0600F599 RID: 62873 RVA: 0x0016BF74 File Offset: 0x0016A174
		static ASceneCapture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SceneCapture");
		}

		// Token: 0x0600F59A RID: 62874 RVA: 0x0016BF84 File Offset: 0x0016A184
		protected ASceneCapture() : this(BuiltinUtils.AllocNativeUObject(ASceneCapture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F59B RID: 62875 RVA: 0x0016BFAC File Offset: 0x0016A1AC
		protected ASceneCapture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008509 RID: 34057
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SceneCapture";

		// Token: 0x0400850A RID: 34058
		private static IntPtr _ClassPtr;

		// Token: 0x0400850B RID: 34059
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400850C RID: 34060
		internal static int __PropertyOffset_MeshComp_DEPRECATED;

		// Token: 0x0400850D RID: 34061
		internal static int __PropertyOffset_SceneComponent;
	}
}
