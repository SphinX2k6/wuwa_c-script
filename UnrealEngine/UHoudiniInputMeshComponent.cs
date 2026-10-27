using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D5 RID: 5333
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputMeshComponent")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UHoudiniInputMeshComponent : UHoudiniInputSceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601351F RID: 79135 RVA: 0x001C6870 File Offset: 0x001C4A70
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputMeshComponent._ClassPtr;
		}

		// Token: 0x06013520 RID: 79136 RVA: 0x001C687C File Offset: 0x001C4A7C
		public UHoudiniInputMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013521 RID: 79137 RVA: 0x001C68A4 File Offset: 0x001C4AA4
		public UHoudiniInputMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x06013522 RID: 79138 RVA: 0x001C68D7 File Offset: 0x001C4AD7
		// (set) Token: 0x06013523 RID: 79139 RVA: 0x001C68EC File Offset: 0x001C4AEC
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)UHoudiniInputMeshComponent.__PropertyOffset_StaticMesh, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UHoudiniInputMeshComponent.__PropertyOffset_StaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06013524 RID: 79140 RVA: 0x001C6911 File Offset: 0x001C4B11
		static UHoudiniInputMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputMeshComponent");
		}

		// Token: 0x06013525 RID: 79141 RVA: 0x001C691F File Offset: 0x001C4B1F
		protected UHoudiniInputMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6FA RID: 42746
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputMeshComponent";

		// Token: 0x0400A6FB RID: 42747
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6FC RID: 42748
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6FD RID: 42749
		internal static int __PropertyOffset_StaticMesh;
	}
}
