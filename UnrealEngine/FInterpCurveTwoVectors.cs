using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000124 RID: 292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveTwoVectors")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveTwoVectors : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060011EF RID: 4591 RVA: 0x0001C6AB File Offset: 0x0001A8AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveTwoVectors._ScriptStructPtr != 0) ? FInterpCurveTwoVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveTwoVectors", ref FInterpCurveTwoVectors._ScriptStructPtr);
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0001C713 File Offset: 0x0001A913
		public TArray<FInterpCurvePointTwoVectors> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointTwoVectors> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointTwoVectors>(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0001C721 File Offset: 0x0001A921
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0001C731 File Offset: 0x0001A931
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0001C742 File Offset: 0x0001A942
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0001C752 File Offset: 0x0001A952
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveTwoVectors.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0001C763 File Offset: 0x0001A963
		public FInterpCurveTwoVectors()
		{
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0001C76B File Offset: 0x0001A96B
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveTwoVectors.StaticStruct();
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0001C777 File Offset: 0x0001A977
		[NullableContext(2)]
		public FInterpCurveTwoVectors(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0001C781 File Offset: 0x0001A981
		public FInterpCurveTwoVectors(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0001C78C File Offset: 0x0001A98C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveTwoVectors(Pointer, false, true);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0001C796 File Offset: 0x0001A996
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveTwoVectors(Pointer, MemoryOwner);
		}

		// Token: 0x04000558 RID: 1368
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveTwoVectors";

		// Token: 0x04000559 RID: 1369
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400055A RID: 1370
		internal static int __PropertyOffset_Points;

		// Token: 0x0400055B RID: 1371
		[Nullable(2)]
		private TArray<FInterpCurvePointTwoVectors> _Points;

		// Token: 0x0400055C RID: 1372
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x0400055D RID: 1373
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
