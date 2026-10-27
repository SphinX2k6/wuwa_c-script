using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023BE RID: 9150
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.ScalarParameterNameAndCurve")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FScalarParameterNameAndCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060226D8 RID: 141016 RVA: 0x0032E9DA File Offset: 0x0032CBDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScalarParameterNameAndCurve._ScriptStructPtr != 0) ? FScalarParameterNameAndCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.ScalarParameterNameAndCurve", ref FScalarParameterNameAndCurve._ScriptStructPtr);
		}

		// Token: 0x1700849E RID: 33950
		// (get) Token: 0x060226D9 RID: 141017 RVA: 0x0032E9FE File Offset: 0x0032CBFE
		// (set) Token: 0x060226DA RID: 141018 RVA: 0x0032EA12 File Offset: 0x0032CC12
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FScalarParameterNameAndCurve.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FScalarParameterNameAndCurve.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x1700849F RID: 33951
		// (get) Token: 0x060226DB RID: 141019 RVA: 0x0032EA28 File Offset: 0x0032CC28
		// (set) Token: 0x060226DC RID: 141020 RVA: 0x0032EA6B File Offset: 0x0032CC6B
		public FMovieSceneFloatChannel ParameterCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._ParameterCurve) == null)
				{
					result = (this._ParameterCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FScalarParameterNameAndCurve.__PropertyOffset_ParameterCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FScalarParameterNameAndCurve.__PropertyOffset_ParameterCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060226DD RID: 141021 RVA: 0x0032EA8C File Offset: 0x0032CC8C
		public FScalarParameterNameAndCurve()
		{
		}

		// Token: 0x060226DE RID: 141022 RVA: 0x0032EA94 File Offset: 0x0032CC94
		public FScalarParameterNameAndCurve(FName ParameterName, FMovieSceneFloatChannel ParameterCurve)
		{
			this.ParameterName = ParameterName;
			this.ParameterCurve = ParameterCurve;
		}

		// Token: 0x060226DF RID: 141023 RVA: 0x0032EAAA File Offset: 0x0032CCAA
		protected override IntPtr GetUStructPtr()
		{
			return FScalarParameterNameAndCurve.StaticStruct();
		}

		// Token: 0x060226E0 RID: 141024 RVA: 0x0032EAB6 File Offset: 0x0032CCB6
		[NullableContext(2)]
		public FScalarParameterNameAndCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060226E1 RID: 141025 RVA: 0x0032EAC0 File Offset: 0x0032CCC0
		public FScalarParameterNameAndCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060226E2 RID: 141026 RVA: 0x0032EACB File Offset: 0x0032CCCB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScalarParameterNameAndCurve(Pointer, false, true);
		}

		// Token: 0x060226E3 RID: 141027 RVA: 0x0032EAD5 File Offset: 0x0032CCD5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScalarParameterNameAndCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04012608 RID: 75272
		public const string __ObjectPath = "/Script/MovieSceneTracks.ScalarParameterNameAndCurve";

		// Token: 0x04012609 RID: 75273
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401260A RID: 75274
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0401260B RID: 75275
		internal static int __PropertyOffset_ParameterCurve;

		// Token: 0x0401260C RID: 75276
		[Nullable(2)]
		private FMovieSceneFloatChannel _ParameterCurve;
	}
}
