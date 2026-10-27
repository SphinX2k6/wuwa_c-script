using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000506 RID: 1286
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.IntegerParameterNameAndCurve")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FIntegerParameterNameAndCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600432B RID: 17195 RVA: 0x0006435B File Offset: 0x0006255B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntegerParameterNameAndCurve._ScriptStructPtr != 0) ? FIntegerParameterNameAndCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.IntegerParameterNameAndCurve", ref FIntegerParameterNameAndCurve._ScriptStructPtr);
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x0006437F File Offset: 0x0006257F
		// (set) Token: 0x0600432D RID: 17197 RVA: 0x00064393 File Offset: 0x00062593
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIntegerParameterNameAndCurve.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIntegerParameterNameAndCurve.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x000643A8 File Offset: 0x000625A8
		// (set) Token: 0x0600432F RID: 17199 RVA: 0x000643EB File Offset: 0x000625EB
		public FMovieSceneIntegerChannel ParameterCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneIntegerChannel result;
				if ((result = this._ParameterCurve) == null)
				{
					result = (this._ParameterCurve = new FMovieSceneIntegerChannel(base.NativePtr + (IntPtr)FIntegerParameterNameAndCurve.__PropertyOffset_ParameterCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneIntegerChannel.StaticStruct(), base.NativePtr + (IntPtr)FIntegerParameterNameAndCurve.__PropertyOffset_ParameterCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x0006440C File Offset: 0x0006260C
		public FIntegerParameterNameAndCurve()
		{
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x00064414 File Offset: 0x00062614
		public FIntegerParameterNameAndCurve(FName ParameterName, FMovieSceneIntegerChannel ParameterCurve)
		{
			this.ParameterName = ParameterName;
			this.ParameterCurve = ParameterCurve;
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x0006442A File Offset: 0x0006262A
		protected override IntPtr GetUStructPtr()
		{
			return FIntegerParameterNameAndCurve.StaticStruct();
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x00064436 File Offset: 0x00062636
		[NullableContext(2)]
		public FIntegerParameterNameAndCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x00064440 File Offset: 0x00062640
		public FIntegerParameterNameAndCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x0006444B File Offset: 0x0006264B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIntegerParameterNameAndCurve(Pointer, false, true);
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00064455 File Offset: 0x00062655
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIntegerParameterNameAndCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040020C2 RID: 8386
		public const string __ObjectPath = "/Script/ControlRig.IntegerParameterNameAndCurve";

		// Token: 0x040020C3 RID: 8387
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020C4 RID: 8388
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040020C5 RID: 8389
		internal static int __PropertyOffset_ParameterCurve;

		// Token: 0x040020C6 RID: 8390
		[Nullable(2)]
		private FMovieSceneIntegerChannel _ParameterCurve;
	}
}
