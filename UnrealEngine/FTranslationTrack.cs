using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001200 RID: 4608
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TranslationTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FTranslationTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010FD0 RID: 69584 RVA: 0x0018EEBD File Offset: 0x0018D0BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTranslationTrack._ScriptStructPtr != 0) ? FTranslationTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TranslationTrack", ref FTranslationTrack._ScriptStructPtr);
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x06010FD1 RID: 69585 RVA: 0x0018EEE4 File Offset: 0x0018D0E4
		// (set) Token: 0x06010FD2 RID: 69586 RVA: 0x0018EF27 File Offset: 0x0018D127
		public TArray<FVector> PosKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PosKeys) == null)
				{
					result = (this._PosKeys = new TArray<FVector>(base.NativePtr + (IntPtr)FTranslationTrack.__PropertyOffset_PosKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PosKeys.CopyAssign(value);
			}
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x06010FD3 RID: 69587 RVA: 0x0018EF38 File Offset: 0x0018D138
		// (set) Token: 0x06010FD4 RID: 69588 RVA: 0x0018EF7B File Offset: 0x0018D17B
		public TArray<float> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<float>(base.NativePtr + (IntPtr)FTranslationTrack.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x06010FD5 RID: 69589 RVA: 0x0018EF89 File Offset: 0x0018D189
		public FTranslationTrack()
		{
		}

		// Token: 0x06010FD6 RID: 69590 RVA: 0x0018EF91 File Offset: 0x0018D191
		public FTranslationTrack(TArray<FVector> PosKeys, TArray<float> Times)
		{
			this.PosKeys = PosKeys;
			this.Times = Times;
		}

		// Token: 0x06010FD7 RID: 69591 RVA: 0x0018EFA7 File Offset: 0x0018D1A7
		protected override IntPtr GetUStructPtr()
		{
			return FTranslationTrack.StaticStruct();
		}

		// Token: 0x06010FD8 RID: 69592 RVA: 0x0018EFB3 File Offset: 0x0018D1B3
		[NullableContext(2)]
		public FTranslationTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010FD9 RID: 69593 RVA: 0x0018EFBD File Offset: 0x0018D1BD
		public FTranslationTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010FDA RID: 69594 RVA: 0x0018EFC8 File Offset: 0x0018D1C8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTranslationTrack(Pointer, false, true);
		}

		// Token: 0x06010FDB RID: 69595 RVA: 0x0018EFD2 File Offset: 0x0018D1D2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTranslationTrack(Pointer, MemoryOwner);
		}

		// Token: 0x0400918C RID: 37260
		public const string __ObjectPath = "/Script/Engine.TranslationTrack";

		// Token: 0x0400918D RID: 37261
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400918E RID: 37262
		internal static int __PropertyOffset_PosKeys;

		// Token: 0x0400918F RID: 37263
		[Nullable(2)]
		private TArray<FVector> _PosKeys;

		// Token: 0x04009190 RID: 37264
		internal static int __PropertyOffset_Times;

		// Token: 0x04009191 RID: 37265
		[Nullable(2)]
		private TArray<float> _Times;
	}
}
