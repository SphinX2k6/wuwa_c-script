using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026DF RID: 9951
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.FloatNameAndCurve")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FFloatNameAndCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024EA2 RID: 151202 RVA: 0x00369936 File Offset: 0x00367B36
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatNameAndCurve._ScriptStructPtr != 0) ? FFloatNameAndCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.FloatNameAndCurve", ref FFloatNameAndCurve._ScriptStructPtr);
		}

		// Token: 0x17008E89 RID: 36489
		// (get) Token: 0x06024EA3 RID: 151203 RVA: 0x0036995A File Offset: 0x00367B5A
		// (set) Token: 0x06024EA4 RID: 151204 RVA: 0x0036996E File Offset: 0x00367B6E
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x17008E8A RID: 36490
		// (get) Token: 0x06024EA5 RID: 151205 RVA: 0x00369983 File Offset: 0x00367B83
		// (set) Token: 0x06024EA6 RID: 151206 RVA: 0x00369997 File Offset: 0x00367B97
		public unsafe FName DisplayName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_DisplayName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_DisplayName) = value;
			}
		}

		// Token: 0x17008E8B RID: 36491
		// (get) Token: 0x06024EA7 RID: 151207 RVA: 0x003699AC File Offset: 0x00367BAC
		// (set) Token: 0x06024EA8 RID: 151208 RVA: 0x003699C0 File Offset: 0x00367BC0
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17008E8C RID: 36492
		// (get) Token: 0x06024EA9 RID: 151209 RVA: 0x003699D8 File Offset: 0x00367BD8
		// (set) Token: 0x06024EAA RID: 151210 RVA: 0x00369A1B File Offset: 0x00367C1B
		public FMovieSceneFloatChannel ParameterCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._ParameterCurve) == null)
				{
					result = (this._ParameterCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_ParameterCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FFloatNameAndCurve.__PropertyOffset_ParameterCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06024EAB RID: 151211 RVA: 0x00369A3C File Offset: 0x00367C3C
		public FFloatNameAndCurve()
		{
		}

		// Token: 0x06024EAC RID: 151212 RVA: 0x00369A44 File Offset: 0x00367C44
		public FFloatNameAndCurve(FName Group, FName DisplayName, FName ParameterName, FMovieSceneFloatChannel ParameterCurve)
		{
			this.Group = Group;
			this.DisplayName = DisplayName;
			this.ParameterName = ParameterName;
			this.ParameterCurve = ParameterCurve;
		}

		// Token: 0x06024EAD RID: 151213 RVA: 0x00369A69 File Offset: 0x00367C69
		protected override IntPtr GetUStructPtr()
		{
			return FFloatNameAndCurve.StaticStruct();
		}

		// Token: 0x06024EAE RID: 151214 RVA: 0x00369A75 File Offset: 0x00367C75
		[NullableContext(2)]
		public FFloatNameAndCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024EAF RID: 151215 RVA: 0x00369A7F File Offset: 0x00367C7F
		public FFloatNameAndCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024EB0 RID: 151216 RVA: 0x00369A8A File Offset: 0x00367C8A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFloatNameAndCurve(Pointer, false, true);
		}

		// Token: 0x06024EB1 RID: 151217 RVA: 0x00369A94 File Offset: 0x00367C94
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFloatNameAndCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04013E45 RID: 81477
		public const string __ObjectPath = "/Script/SequenceDialogue.FloatNameAndCurve";

		// Token: 0x04013E46 RID: 81478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013E47 RID: 81479
		internal static int __PropertyOffset_Group;

		// Token: 0x04013E48 RID: 81480
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04013E49 RID: 81481
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04013E4A RID: 81482
		internal static int __PropertyOffset_ParameterCurve;

		// Token: 0x04013E4B RID: 81483
		[Nullable(2)]
		private FMovieSceneFloatChannel _ParameterCurve;
	}
}
