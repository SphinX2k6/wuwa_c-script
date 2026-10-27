using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028BF RID: 10431
	[UnrealObjectPath("/Script/StandinActor.StandInMeshActor")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class AStandInMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026BBC RID: 158652 RVA: 0x003B16A1 File Offset: 0x003AF8A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AStandInMeshActor._ClassPtr;
		}

		// Token: 0x06026BBD RID: 158653 RVA: 0x003B16B0 File Offset: 0x003AF8B0
		public AStandInMeshActor() : this(BuiltinUtils.AllocNativeUObject(AStandInMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BBE RID: 158654 RVA: 0x003B16D8 File Offset: 0x003AF8D8
		[NullableContext(1)]
		public AStandInMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AStandInMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700953D RID: 38205
		// (get) Token: 0x06026BBF RID: 158655 RVA: 0x003B170B File Offset: 0x003AF90B
		// (set) Token: 0x06026BC0 RID: 158656 RVA: 0x003B171F File Offset: 0x003AF91F
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AStandInMeshActor.__PropertyOffset_StaticMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AStandInMeshActor.__PropertyOffset_StaticMeshComponent, value);
			}
		}

		// Token: 0x06026BC1 RID: 158657 RVA: 0x003B1734 File Offset: 0x003AF934
		static AStandInMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StandinActor.StandInMeshActor");
		}

		// Token: 0x06026BC2 RID: 158658 RVA: 0x003B1742 File Offset: 0x003AF942
		protected AStandInMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015417 RID: 87063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StandinActor.StandInMeshActor";

		// Token: 0x04015418 RID: 87064
		private static IntPtr _ClassPtr;

		// Token: 0x04015419 RID: 87065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401541A RID: 87066
		internal static int __PropertyOffset_StaticMeshComponent;
	}
}
