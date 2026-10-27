using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C31 RID: 3121
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.HLODInstancingKey")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FHLODInstancingKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009E38 RID: 40504 RVA: 0x000E0E42 File Offset: 0x000DF042
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODInstancingKey._ScriptStructPtr != 0) ? FHLODInstancingKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODInstancingKey", ref FHLODInstancingKey._ScriptStructPtr);
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x000E0E66 File Offset: 0x000DF066
		// (set) Token: 0x06009E3A RID: 40506 RVA: 0x000E0E7A File Offset: 0x000DF07A
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FHLODInstancingKey.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHLODInstancingKey.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x06009E3B RID: 40507 RVA: 0x000E0E8F File Offset: 0x000DF08F
		// (set) Token: 0x06009E3C RID: 40508 RVA: 0x000E0EA3 File Offset: 0x000DF0A3
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FHLODInstancingKey.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHLODInstancingKey.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x000E0EB8 File Offset: 0x000DF0B8
		public FHLODInstancingKey()
		{
		}

		// Token: 0x06009E3E RID: 40510 RVA: 0x000E0EC0 File Offset: 0x000DF0C0
		[NullableContext(1)]
		public FHLODInstancingKey(UStaticMesh StaticMesh, UMaterialInterface Material)
		{
			this.StaticMesh = StaticMesh;
			this.Material = Material;
		}

		// Token: 0x06009E3F RID: 40511 RVA: 0x000E0ED6 File Offset: 0x000DF0D6
		protected override IntPtr GetUStructPtr()
		{
			return FHLODInstancingKey.StaticStruct();
		}

		// Token: 0x06009E40 RID: 40512 RVA: 0x000E0EE2 File Offset: 0x000DF0E2
		public FHLODInstancingKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E41 RID: 40513 RVA: 0x000E0EEC File Offset: 0x000DF0EC
		public FHLODInstancingKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x000E0EF7 File Offset: 0x000DF0F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODInstancingKey(Pointer, false, true);
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x000E0F01 File Offset: 0x000DF101
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODInstancingKey(Pointer, MemoryOwner);
		}

		// Token: 0x0400573A RID: 22330
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HLODInstancingKey";

		// Token: 0x0400573B RID: 22331
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400573C RID: 22332
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400573D RID: 22333
		internal static int __PropertyOffset_Material;
	}
}
