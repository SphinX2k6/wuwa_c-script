using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001090 RID: 4240
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RichCurve")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRichCurve : FRealCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F25D RID: 62045 RVA: 0x001678B7 File Offset: 0x00165AB7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRichCurve._ScriptStructPtr != 0) ? FRichCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RichCurve", ref FRichCurve._ScriptStructPtr);
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600F25E RID: 62046 RVA: 0x001678DC File Offset: 0x00165ADC
		// (set) Token: 0x0600F25F RID: 62047 RVA: 0x0016791F File Offset: 0x00165B1F
		public TArray<FRichCurveKey> Keys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRichCurveKey> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<FRichCurveKey>(base.NativePtr + (IntPtr)FRichCurve.__PropertyOffset_Keys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x0016792D File Offset: 0x00165B2D
		public FRichCurve()
		{
		}

		// Token: 0x0600F261 RID: 62049 RVA: 0x00167935 File Offset: 0x00165B35
		[NullableContext(0)]
		public FRichCurve([Nullable(1)] TArray<FRichCurveKey> Keys, float DefaultValue, TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap, TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap, [Nullable(1)] FKeyHandleMap KeyHandlesToIndices)
		{
			this.Keys = Keys;
			base.DefaultValue = DefaultValue;
			base.PreInfinityExtrap = PreInfinityExtrap;
			base.PostInfinityExtrap = PostInfinityExtrap;
			base.KeyHandlesToIndices = KeyHandlesToIndices;
		}

		// Token: 0x0600F262 RID: 62050 RVA: 0x00167962 File Offset: 0x00165B62
		protected override IntPtr GetUStructPtr()
		{
			return FRichCurve.StaticStruct();
		}

		// Token: 0x0600F263 RID: 62051 RVA: 0x0016796E File Offset: 0x00165B6E
		[NullableContext(2)]
		public FRichCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F264 RID: 62052 RVA: 0x00167978 File Offset: 0x00165B78
		public FRichCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F265 RID: 62053 RVA: 0x00167983 File Offset: 0x00165B83
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRichCurve(Pointer, false, true);
		}

		// Token: 0x0600F266 RID: 62054 RVA: 0x0016798D File Offset: 0x00165B8D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRichCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400837B RID: 33659
		public new const string __ObjectPath = "/Script/Engine.RichCurve";

		// Token: 0x0400837C RID: 33660
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400837D RID: 33661
		internal static int __PropertyOffset_Keys;

		// Token: 0x0400837E RID: 33662
		[Nullable(2)]
		private TArray<FRichCurveKey> _Keys;
	}
}
