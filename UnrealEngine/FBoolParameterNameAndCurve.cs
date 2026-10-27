using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200231D RID: 8989
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.BoolParameterNameAndCurve")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FBoolParameterNameAndCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022062 RID: 139362 RVA: 0x00324C34 File Offset: 0x00322E34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoolParameterNameAndCurve._ScriptStructPtr != 0) ? FBoolParameterNameAndCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.BoolParameterNameAndCurve", ref FBoolParameterNameAndCurve._ScriptStructPtr);
		}

		// Token: 0x17008374 RID: 33652
		// (get) Token: 0x06022063 RID: 139363 RVA: 0x00324C58 File Offset: 0x00322E58
		// (set) Token: 0x06022064 RID: 139364 RVA: 0x00324C6C File Offset: 0x00322E6C
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoolParameterNameAndCurve.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoolParameterNameAndCurve.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17008375 RID: 33653
		// (get) Token: 0x06022065 RID: 139365 RVA: 0x00324C84 File Offset: 0x00322E84
		// (set) Token: 0x06022066 RID: 139366 RVA: 0x00324CC7 File Offset: 0x00322EC7
		public FMovieSceneBoolChannel ParameterCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneBoolChannel result;
				if ((result = this._ParameterCurve) == null)
				{
					result = (this._ParameterCurve = new FMovieSceneBoolChannel(base.NativePtr + (IntPtr)FBoolParameterNameAndCurve.__PropertyOffset_ParameterCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneBoolChannel.StaticStruct(), base.NativePtr + (IntPtr)FBoolParameterNameAndCurve.__PropertyOffset_ParameterCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022067 RID: 139367 RVA: 0x00324CE8 File Offset: 0x00322EE8
		public FBoolParameterNameAndCurve()
		{
		}

		// Token: 0x06022068 RID: 139368 RVA: 0x00324CF0 File Offset: 0x00322EF0
		public FBoolParameterNameAndCurve(FName ParameterName, FMovieSceneBoolChannel ParameterCurve)
		{
			this.ParameterName = ParameterName;
			this.ParameterCurve = ParameterCurve;
		}

		// Token: 0x06022069 RID: 139369 RVA: 0x00324D06 File Offset: 0x00322F06
		protected override IntPtr GetUStructPtr()
		{
			return FBoolParameterNameAndCurve.StaticStruct();
		}

		// Token: 0x0602206A RID: 139370 RVA: 0x00324D12 File Offset: 0x00322F12
		[NullableContext(2)]
		public FBoolParameterNameAndCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602206B RID: 139371 RVA: 0x00324D1C File Offset: 0x00322F1C
		public FBoolParameterNameAndCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602206C RID: 139372 RVA: 0x00324D27 File Offset: 0x00322F27
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoolParameterNameAndCurve(Pointer, false, true);
		}

		// Token: 0x0602206D RID: 139373 RVA: 0x00324D31 File Offset: 0x00322F31
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoolParameterNameAndCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04012270 RID: 74352
		public const string __ObjectPath = "/Script/MovieSceneTracks.BoolParameterNameAndCurve";

		// Token: 0x04012271 RID: 74353
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012272 RID: 74354
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04012273 RID: 74355
		internal static int __PropertyOffset_ParameterCurve;

		// Token: 0x04012274 RID: 74356
		[Nullable(2)]
		private FMovieSceneBoolChannel _ParameterCurve;
	}
}
