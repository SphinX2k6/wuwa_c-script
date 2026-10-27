using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010AA RID: 4266
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RotationTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRotationTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F3E9 RID: 62441 RVA: 0x00169C3D File Offset: 0x00167E3D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRotationTrack._ScriptStructPtr != 0) ? FRotationTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RotationTrack", ref FRotationTrack._ScriptStructPtr);
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x0600F3EA RID: 62442 RVA: 0x00169C64 File Offset: 0x00167E64
		// (set) Token: 0x0600F3EB RID: 62443 RVA: 0x00169CA7 File Offset: 0x00167EA7
		public TArray<FQuat> RotKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._RotKeys) == null)
				{
					result = (this._RotKeys = new TArray<FQuat>(base.NativePtr + (IntPtr)FRotationTrack.__PropertyOffset_RotKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotKeys.CopyAssign(value);
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0600F3EC RID: 62444 RVA: 0x00169CB8 File Offset: 0x00167EB8
		// (set) Token: 0x0600F3ED RID: 62445 RVA: 0x00169CFB File Offset: 0x00167EFB
		public TArray<float> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<float>(base.NativePtr + (IntPtr)FRotationTrack.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x0600F3EE RID: 62446 RVA: 0x00169D09 File Offset: 0x00167F09
		public FRotationTrack()
		{
		}

		// Token: 0x0600F3EF RID: 62447 RVA: 0x00169D11 File Offset: 0x00167F11
		public FRotationTrack(TArray<FQuat> RotKeys, TArray<float> Times)
		{
			this.RotKeys = RotKeys;
			this.Times = Times;
		}

		// Token: 0x0600F3F0 RID: 62448 RVA: 0x00169D27 File Offset: 0x00167F27
		protected override IntPtr GetUStructPtr()
		{
			return FRotationTrack.StaticStruct();
		}

		// Token: 0x0600F3F1 RID: 62449 RVA: 0x00169D33 File Offset: 0x00167F33
		[NullableContext(2)]
		public FRotationTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F3F2 RID: 62450 RVA: 0x00169D3D File Offset: 0x00167F3D
		public FRotationTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F3F3 RID: 62451 RVA: 0x00169D48 File Offset: 0x00167F48
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRotationTrack(Pointer, false, true);
		}

		// Token: 0x0600F3F4 RID: 62452 RVA: 0x00169D52 File Offset: 0x00167F52
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRotationTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04008435 RID: 33845
		public const string __ObjectPath = "/Script/Engine.RotationTrack";

		// Token: 0x04008436 RID: 33846
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008437 RID: 33847
		internal static int __PropertyOffset_RotKeys;

		// Token: 0x04008438 RID: 33848
		[Nullable(2)]
		private TArray<FQuat> _RotKeys;

		// Token: 0x04008439 RID: 33849
		internal static int __PropertyOffset_Times;

		// Token: 0x0400843A RID: 33850
		[Nullable(2)]
		private TArray<float> _Times;
	}
}
