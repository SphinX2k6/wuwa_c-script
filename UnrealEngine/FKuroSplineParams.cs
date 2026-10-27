using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001910 RID: 6416
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSplineParams")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroSplineParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017D07 RID: 97543 RVA: 0x0022E10D File Offset: 0x0022C30D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSplineParams._ScriptStructPtr != 0) ? FKuroSplineParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroSplineParams", ref FKuroSplineParams._ScriptStructPtr);
		}

		// Token: 0x17005FBF RID: 24511
		// (get) Token: 0x06017D08 RID: 97544 RVA: 0x0022E134 File Offset: 0x0022C334
		// (set) Token: 0x06017D09 RID: 97545 RVA: 0x0022E177 File Offset: 0x0022C377
		public TArray<FVector> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FVector>(base.NativePtr + (IntPtr)FKuroSplineParams.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17005FC0 RID: 24512
		// (get) Token: 0x06017D0A RID: 97546 RVA: 0x0022E185 File Offset: 0x0022C385
		// (set) Token: 0x06017D0B RID: 97547 RVA: 0x0022E195 File Offset: 0x0022C395
		public unsafe bool bClosedLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSplineParams.__PropertyOffset_bClosedLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSplineParams.__PropertyOffset_bClosedLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x06017D0C RID: 97548 RVA: 0x0022E1A6 File Offset: 0x0022C3A6
		public FKuroSplineParams()
		{
		}

		// Token: 0x06017D0D RID: 97549 RVA: 0x0022E1AE File Offset: 0x0022C3AE
		public FKuroSplineParams(TArray<FVector> Points, bool bClosedLoop)
		{
			this.Points = Points;
			this.bClosedLoop = bClosedLoop;
		}

		// Token: 0x06017D0E RID: 97550 RVA: 0x0022E1C4 File Offset: 0x0022C3C4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSplineParams.StaticStruct();
		}

		// Token: 0x06017D0F RID: 97551 RVA: 0x0022E1D0 File Offset: 0x0022C3D0
		[NullableContext(2)]
		public FKuroSplineParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017D10 RID: 97552 RVA: 0x0022E1DA File Offset: 0x0022C3DA
		public FKuroSplineParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017D11 RID: 97553 RVA: 0x0022E1E5 File Offset: 0x0022C3E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSplineParams(Pointer, false, true);
		}

		// Token: 0x06017D12 RID: 97554 RVA: 0x0022E1EF File Offset: 0x0022C3EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSplineParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400CE86 RID: 52870
		public const string __ObjectPath = "/Script/KuroGameplay.KuroSplineParams";

		// Token: 0x0400CE87 RID: 52871
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CE88 RID: 52872
		internal static int __PropertyOffset_Points;

		// Token: 0x0400CE89 RID: 52873
		[Nullable(2)]
		private TArray<FVector> _Points;

		// Token: 0x0400CE8A RID: 52874
		internal static int __PropertyOffset_bClosedLoop;
	}
}
