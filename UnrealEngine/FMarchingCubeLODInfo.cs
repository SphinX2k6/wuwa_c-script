using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D71 RID: 3441
	[UnrealObjectPath("/Script/Engine.MarchingCubeLODInfo")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FMarchingCubeLODInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B9D5 RID: 47573 RVA: 0x001085AA File Offset: 0x001067AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMarchingCubeLODInfo._ScriptStructPtr != 0) ? FMarchingCubeLODInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MarchingCubeLODInfo", ref FMarchingCubeLODInfo._ScriptStructPtr);
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x0600B9D6 RID: 47574 RVA: 0x001085CE File Offset: 0x001067CE
		// (set) Token: 0x0600B9D7 RID: 47575 RVA: 0x001085DE File Offset: 0x001067DE
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubeLODInfo.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubeLODInfo.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x0600B9D8 RID: 47576 RVA: 0x001085EF File Offset: 0x001067EF
		// (set) Token: 0x0600B9D9 RID: 47577 RVA: 0x001085FF File Offset: 0x001067FF
		public unsafe int CubeStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMarchingCubeLODInfo.__PropertyOffset_CubeStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMarchingCubeLODInfo.__PropertyOffset_CubeStepSize) = value;
			}
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x00108610 File Offset: 0x00106810
		public FMarchingCubeLODInfo()
		{
		}

		// Token: 0x0600B9DB RID: 47579 RVA: 0x00108618 File Offset: 0x00106818
		public FMarchingCubeLODInfo(float Distance, int CubeStepSize)
		{
			this.Distance = Distance;
			this.CubeStepSize = CubeStepSize;
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x0010862E File Offset: 0x0010682E
		protected override IntPtr GetUStructPtr()
		{
			return FMarchingCubeLODInfo.StaticStruct();
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x0010863A File Offset: 0x0010683A
		[NullableContext(2)]
		public FMarchingCubeLODInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x00108644 File Offset: 0x00106844
		public FMarchingCubeLODInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x0010864F File Offset: 0x0010684F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMarchingCubeLODInfo(Pointer, false, true);
		}

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x00108659 File Offset: 0x00106859
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMarchingCubeLODInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006158 RID: 24920
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MarchingCubeLODInfo";

		// Token: 0x04006159 RID: 24921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400615A RID: 24922
		internal static int __PropertyOffset_Distance;

		// Token: 0x0400615B RID: 24923
		internal static int __PropertyOffset_CubeStepSize;
	}
}
