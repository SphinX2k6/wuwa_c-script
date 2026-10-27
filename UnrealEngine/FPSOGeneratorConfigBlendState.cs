using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001049 RID: 4169
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigBlendState")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPSOGeneratorConfigBlendState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED32 RID: 60722 RVA: 0x0015FC57 File Offset: 0x0015DE57
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigBlendState._ScriptStructPtr != 0) ? FPSOGeneratorConfigBlendState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigBlendState", ref FPSOGeneratorConfigBlendState._ScriptStructPtr);
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600ED33 RID: 60723 RVA: 0x0015FC7C File Offset: 0x0015DE7C
		// (set) Token: 0x0600ED34 RID: 60724 RVA: 0x0015FCBF File Offset: 0x0015DEBF
		public TArray<FPSOGeneratorConfigBlendStateTarget> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOGeneratorConfigBlendStateTarget> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FPSOGeneratorConfigBlendStateTarget>(base.NativePtr + (IntPtr)FPSOGeneratorConfigBlendState.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600ED35 RID: 60725 RVA: 0x0015FCCD File Offset: 0x0015DECD
		// (set) Token: 0x0600ED36 RID: 60726 RVA: 0x0015FCDD File Offset: 0x0015DEDD
		public unsafe bool bUseIndependentRenderTargetBlendStates
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigBlendState.__PropertyOffset_bUseIndependentRenderTargetBlendStates) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigBlendState.__PropertyOffset_bUseIndependentRenderTargetBlendStates) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600ED37 RID: 60727 RVA: 0x0015FCEE File Offset: 0x0015DEEE
		// (set) Token: 0x0600ED38 RID: 60728 RVA: 0x0015FCFE File Offset: 0x0015DEFE
		public unsafe bool bUseAlphaToCoverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigBlendState.__PropertyOffset_bUseAlphaToCoverage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigBlendState.__PropertyOffset_bUseAlphaToCoverage) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600ED39 RID: 60729 RVA: 0x0015FD0F File Offset: 0x0015DF0F
		public FPSOGeneratorConfigBlendState()
		{
		}

		// Token: 0x0600ED3A RID: 60730 RVA: 0x0015FD17 File Offset: 0x0015DF17
		public FPSOGeneratorConfigBlendState(TArray<FPSOGeneratorConfigBlendStateTarget> Targets, bool bUseIndependentRenderTargetBlendStates, bool bUseAlphaToCoverage)
		{
			this.Targets = Targets;
			this.bUseIndependentRenderTargetBlendStates = bUseIndependentRenderTargetBlendStates;
			this.bUseAlphaToCoverage = bUseAlphaToCoverage;
		}

		// Token: 0x0600ED3B RID: 60731 RVA: 0x0015FD34 File Offset: 0x0015DF34
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigBlendState.StaticStruct();
		}

		// Token: 0x0600ED3C RID: 60732 RVA: 0x0015FD40 File Offset: 0x0015DF40
		[NullableContext(2)]
		public FPSOGeneratorConfigBlendState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED3D RID: 60733 RVA: 0x0015FD4A File Offset: 0x0015DF4A
		public FPSOGeneratorConfigBlendState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED3E RID: 60734 RVA: 0x0015FD55 File Offset: 0x0015DF55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigBlendState(Pointer, false, true);
		}

		// Token: 0x0600ED3F RID: 60735 RVA: 0x0015FD5F File Offset: 0x0015DF5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigBlendState(Pointer, MemoryOwner);
		}

		// Token: 0x04008063 RID: 32867
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigBlendState";

		// Token: 0x04008064 RID: 32868
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008065 RID: 32869
		internal static int __PropertyOffset_Targets;

		// Token: 0x04008066 RID: 32870
		[Nullable(2)]
		private TArray<FPSOGeneratorConfigBlendStateTarget> _Targets;

		// Token: 0x04008067 RID: 32871
		internal static int __PropertyOffset_bUseIndependentRenderTargetBlendStates;

		// Token: 0x04008068 RID: 32872
		internal static int __PropertyOffset_bUseAlphaToCoverage;
	}
}
