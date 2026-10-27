using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D7 RID: 5335
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputSceneComponent")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UHoudiniInputSceneComponent : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013549 RID: 79177 RVA: 0x001C6BE7 File Offset: 0x001C4DE7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputSceneComponent._ClassPtr;
		}

		// Token: 0x0601354A RID: 79178 RVA: 0x001C6BF4 File Offset: 0x001C4DF4
		public UHoudiniInputSceneComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSceneComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601354B RID: 79179 RVA: 0x001C6C1C File Offset: 0x001C4E1C
		[NullableContext(1)]
		public UHoudiniInputSceneComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputSceneComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B5D RID: 19293
		// (get) Token: 0x0601354C RID: 79180 RVA: 0x001C6C4F File Offset: 0x001C4E4F
		// (set) Token: 0x0601354D RID: 79181 RVA: 0x001C6C63 File Offset: 0x001C4E63
		public unsafe FTransform ActorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputSceneComponent.__PropertyOffset_ActorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputSceneComponent.__PropertyOffset_ActorTransform) = value;
			}
		}

		// Token: 0x0601354E RID: 79182 RVA: 0x001C6C78 File Offset: 0x001C4E78
		static UHoudiniInputSceneComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputSceneComponent");
		}

		// Token: 0x0601354F RID: 79183 RVA: 0x001C6C86 File Offset: 0x001C4E86
		protected UHoudiniInputSceneComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A711 RID: 42769
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputSceneComponent";

		// Token: 0x0400A712 RID: 42770
		private static IntPtr _ClassPtr;

		// Token: 0x0400A713 RID: 42771
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A714 RID: 42772
		internal static int __PropertyOffset_ActorTransform;
	}
}
