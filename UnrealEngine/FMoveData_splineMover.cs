using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BFF RID: 7167
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MoveData_splineMover")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMoveData_splineMover : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BA97 RID: 113303 RVA: 0x0028B650 File Offset: 0x00289850
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMoveData_splineMover._ScriptStructPtr != 0) ? FMoveData_splineMover._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MoveData_splineMover", ref FMoveData_splineMover._ScriptStructPtr);
		}

		// Token: 0x17006F93 RID: 28563
		// (get) Token: 0x0601BA98 RID: 113304 RVA: 0x0028B674 File Offset: 0x00289874
		// (set) Token: 0x0601BA99 RID: 113305 RVA: 0x0028B688 File Offset: 0x00289888
		[Nullable(2)]
		public unsafe UStaticMeshComponent TargetMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FMoveData_splineMover.__PropertyOffset_TargetMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMoveData_splineMover.__PropertyOffset_TargetMesh, value);
			}
		}

		// Token: 0x17006F94 RID: 28564
		// (get) Token: 0x0601BA9A RID: 113306 RVA: 0x0028B69D File Offset: 0x0028989D
		// (set) Token: 0x0601BA9B RID: 113307 RVA: 0x0028B6AD File Offset: 0x002898AD
		public unsafe float CurrentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMoveData_splineMover.__PropertyOffset_CurrentDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMoveData_splineMover.__PropertyOffset_CurrentDistance) = value;
			}
		}

		// Token: 0x0601BA9C RID: 113308 RVA: 0x0028B6BE File Offset: 0x002898BE
		public FMoveData_splineMover()
		{
		}

		// Token: 0x0601BA9D RID: 113309 RVA: 0x0028B6C6 File Offset: 0x002898C6
		[NullableContext(1)]
		public FMoveData_splineMover(UStaticMeshComponent TargetMesh, float CurrentDistance)
		{
			this.TargetMesh = TargetMesh;
			this.CurrentDistance = CurrentDistance;
		}

		// Token: 0x0601BA9E RID: 113310 RVA: 0x0028B6DC File Offset: 0x002898DC
		protected override IntPtr GetUStructPtr()
		{
			return FMoveData_splineMover.StaticStruct();
		}

		// Token: 0x0601BA9F RID: 113311 RVA: 0x0028B6E8 File Offset: 0x002898E8
		[NullableContext(2)]
		public FMoveData_splineMover(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BAA0 RID: 113312 RVA: 0x0028B6F2 File Offset: 0x002898F2
		public FMoveData_splineMover(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BAA1 RID: 113313 RVA: 0x0028B6FD File Offset: 0x002898FD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMoveData_splineMover(Pointer, false, true);
		}

		// Token: 0x0601BAA2 RID: 113314 RVA: 0x0028B707 File Offset: 0x00289907
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMoveData_splineMover(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE07 RID: 60935
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MoveData_splineMover";

		// Token: 0x0400EE08 RID: 60936
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE09 RID: 60937
		internal static int __PropertyOffset_TargetMesh;

		// Token: 0x0400EE0A RID: 60938
		internal static int __PropertyOffset_CurrentDistance;
	}
}
