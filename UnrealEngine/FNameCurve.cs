using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC3 RID: 3779
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NameCurve")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FNameCurve : FIndexedCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CC9F RID: 52383 RVA: 0x0012A23B File Offset: 0x0012843B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNameCurve._ScriptStructPtr != 0) ? FNameCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NameCurve", ref FNameCurve._ScriptStructPtr);
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x0600CCA0 RID: 52384 RVA: 0x0012A260 File Offset: 0x00128460
		// (set) Token: 0x0600CCA1 RID: 52385 RVA: 0x0012A2A3 File Offset: 0x001284A3
		public TArray<FNameCurveKey> Keys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNameCurveKey> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<FNameCurveKey>(base.NativePtr + (IntPtr)FNameCurve.__PropertyOffset_Keys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x0012A2B1 File Offset: 0x001284B1
		public FNameCurve()
		{
		}

		// Token: 0x0600CCA3 RID: 52387 RVA: 0x0012A2B9 File Offset: 0x001284B9
		public FNameCurve(TArray<FNameCurveKey> Keys, FKeyHandleMap KeyHandlesToIndices)
		{
			this.Keys = Keys;
			base.KeyHandlesToIndices = KeyHandlesToIndices;
		}

		// Token: 0x0600CCA4 RID: 52388 RVA: 0x0012A2CF File Offset: 0x001284CF
		protected override IntPtr GetUStructPtr()
		{
			return FNameCurve.StaticStruct();
		}

		// Token: 0x0600CCA5 RID: 52389 RVA: 0x0012A2DB File Offset: 0x001284DB
		[NullableContext(2)]
		public FNameCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x0012A2E5 File Offset: 0x001284E5
		public FNameCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x0012A2F0 File Offset: 0x001284F0
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNameCurve(Pointer, false, true);
		}

		// Token: 0x0600CCA8 RID: 52392 RVA: 0x0012A2FA File Offset: 0x001284FA
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNameCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04006E2E RID: 28206
		public new const string __ObjectPath = "/Script/Engine.NameCurve";

		// Token: 0x04006E2F RID: 28207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E30 RID: 28208
		internal static int __PropertyOffset_Keys;

		// Token: 0x04006E31 RID: 28209
		[Nullable(2)]
		private TArray<FNameCurveKey> _Keys;
	}
}
