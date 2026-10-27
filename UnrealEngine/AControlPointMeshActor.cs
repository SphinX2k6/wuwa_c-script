using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F55 RID: 8021
	[UnrealObjectPath("/Script/Landscape.ControlPointMeshActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AControlPointMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E787 RID: 124807 RVA: 0x002D4B95 File Offset: 0x002D2D95
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AControlPointMeshActor._ClassPtr;
		}

		// Token: 0x0601E788 RID: 124808 RVA: 0x002D4BA4 File Offset: 0x002D2DA4
		public AControlPointMeshActor() : this(BuiltinUtils.AllocNativeUObject(AControlPointMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E789 RID: 124809 RVA: 0x002D4BCC File Offset: 0x002D2DCC
		[NullableContext(1)]
		public AControlPointMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AControlPointMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700792D RID: 31021
		// (get) Token: 0x0601E78A RID: 124810 RVA: 0x002D4BFF File Offset: 0x002D2DFF
		// (set) Token: 0x0601E78B RID: 124811 RVA: 0x002D4C13 File Offset: 0x002D2E13
		[Nullable(2)]
		public unsafe UControlPointMeshComponent ControlPointMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlPointMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AControlPointMeshActor.__PropertyOffset_ControlPointMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AControlPointMeshActor.__PropertyOffset_ControlPointMeshComponent, value);
			}
		}

		// Token: 0x0601E78C RID: 124812 RVA: 0x002D4C28 File Offset: 0x002D2E28
		static AControlPointMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.ControlPointMeshActor");
		}

		// Token: 0x0601E78D RID: 124813 RVA: 0x002D4C36 File Offset: 0x002D2E36
		protected AControlPointMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010743 RID: 67395
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.ControlPointMeshActor";

		// Token: 0x04010744 RID: 67396
		private static IntPtr _ClassPtr;

		// Token: 0x04010745 RID: 67397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010746 RID: 67398
		internal static int __PropertyOffset_ControlPointMeshComponent;
	}
}
