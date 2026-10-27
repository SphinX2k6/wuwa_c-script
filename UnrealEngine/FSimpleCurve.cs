using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010EB RID: 4331
	[UnrealObjectPath("/Script/Engine.SimpleCurve")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FSimpleCurve : FRealCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F887 RID: 63623 RVA: 0x0016F9A7 File Offset: 0x0016DBA7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimpleCurve._ScriptStructPtr != 0) ? FSimpleCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SimpleCurve", ref FSimpleCurve._ScriptStructPtr);
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x0600F888 RID: 63624 RVA: 0x0016F9CB File Offset: 0x0016DBCB
		// (set) Token: 0x0600F889 RID: 63625 RVA: 0x0016F9DF File Offset: 0x0016DBDF
		public unsafe TEnumAsByte<ERichCurveInterpMode> InterpMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleCurve.__PropertyOffset_InterpMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleCurve.__PropertyOffset_InterpMode) = value;
			}
		}

		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0600F88A RID: 63626 RVA: 0x0016F9F4 File Offset: 0x0016DBF4
		// (set) Token: 0x0600F88B RID: 63627 RVA: 0x0016FA37 File Offset: 0x0016DC37
		[Nullable(1)]
		public TArray<FSimpleCurveKey> Keys
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSimpleCurveKey> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<FSimpleCurveKey>(base.NativePtr + (IntPtr)FSimpleCurve.__PropertyOffset_Keys, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x0600F88C RID: 63628 RVA: 0x0016FA45 File Offset: 0x0016DC45
		public FSimpleCurve()
		{
		}

		// Token: 0x0600F88D RID: 63629 RVA: 0x0016FA4D File Offset: 0x0016DC4D
		public FSimpleCurve(TEnumAsByte<ERichCurveInterpMode> InterpMode, [Nullable(1)] TArray<FSimpleCurveKey> Keys, float DefaultValue, TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap, TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap, [Nullable(1)] FKeyHandleMap KeyHandlesToIndices)
		{
			this.InterpMode = InterpMode;
			this.Keys = Keys;
			base.DefaultValue = DefaultValue;
			base.PreInfinityExtrap = PreInfinityExtrap;
			base.PostInfinityExtrap = PostInfinityExtrap;
			base.KeyHandlesToIndices = KeyHandlesToIndices;
		}

		// Token: 0x0600F88E RID: 63630 RVA: 0x0016FA82 File Offset: 0x0016DC82
		protected override IntPtr GetUStructPtr()
		{
			return FSimpleCurve.StaticStruct();
		}

		// Token: 0x0600F88F RID: 63631 RVA: 0x0016FA8E File Offset: 0x0016DC8E
		[NullableContext(2)]
		public FSimpleCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F890 RID: 63632 RVA: 0x0016FA98 File Offset: 0x0016DC98
		public FSimpleCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F891 RID: 63633 RVA: 0x0016FAA3 File Offset: 0x0016DCA3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimpleCurve(Pointer, false, true);
		}

		// Token: 0x0600F892 RID: 63634 RVA: 0x0016FAAD File Offset: 0x0016DCAD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimpleCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04008648 RID: 34376
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SimpleCurve";

		// Token: 0x04008649 RID: 34377
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400864A RID: 34378
		internal static int __PropertyOffset_InterpMode;

		// Token: 0x0400864B RID: 34379
		internal static int __PropertyOffset_Keys;

		// Token: 0x0400864C RID: 34380
		[Nullable(2)]
		private TArray<FSimpleCurveKey> _Keys;
	}
}
