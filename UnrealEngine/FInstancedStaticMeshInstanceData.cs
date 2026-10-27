using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C64 RID: 3172
	[UnrealObjectPath("/Script/Engine.InstancedStaticMeshInstanceData")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FInstancedStaticMeshInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A162 RID: 41314 RVA: 0x000E5500 File Offset: 0x000E3700
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstancedStaticMeshInstanceData._ScriptStructPtr != 0) ? FInstancedStaticMeshInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstancedStaticMeshInstanceData", ref FInstancedStaticMeshInstanceData._ScriptStructPtr);
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x0600A163 RID: 41315 RVA: 0x000E5524 File Offset: 0x000E3724
		// (set) Token: 0x0600A164 RID: 41316 RVA: 0x000E5538 File Offset: 0x000E3738
		public unsafe FMatrix Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstancedStaticMeshInstanceData.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstancedStaticMeshInstanceData.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x000E554D File Offset: 0x000E374D
		public FInstancedStaticMeshInstanceData()
		{
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x000E5555 File Offset: 0x000E3755
		public FInstancedStaticMeshInstanceData(FMatrix Transform)
		{
			this.Transform = Transform;
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x000E5564 File Offset: 0x000E3764
		protected override IntPtr GetUStructPtr()
		{
			return FInstancedStaticMeshInstanceData.StaticStruct();
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x000E5570 File Offset: 0x000E3770
		[NullableContext(2)]
		public FInstancedStaticMeshInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x000E557A File Offset: 0x000E377A
		public FInstancedStaticMeshInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x000E5585 File Offset: 0x000E3785
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstancedStaticMeshInstanceData(Pointer, false, true);
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x000E558F File Offset: 0x000E378F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstancedStaticMeshInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040058A9 RID: 22697
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InstancedStaticMeshInstanceData";

		// Token: 0x040058AA RID: 22698
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058AB RID: 22699
		internal static int __PropertyOffset_Transform;
	}
}
