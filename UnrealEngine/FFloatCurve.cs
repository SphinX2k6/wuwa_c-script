using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BD7 RID: 3031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FloatCurve")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FFloatCurve : FAnimCurveBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600950C RID: 38156 RVA: 0x000D4A85 File Offset: 0x000D2C85
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatCurve._ScriptStructPtr != 0) ? FFloatCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FloatCurve", ref FFloatCurve._ScriptStructPtr);
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x0600950D RID: 38157 RVA: 0x000D4AAC File Offset: 0x000D2CAC
		// (set) Token: 0x0600950E RID: 38158 RVA: 0x000D4AEF File Offset: 0x000D2CEF
		public FRichCurve FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FRichCurve(base.NativePtr + (IntPtr)FFloatCurve.__PropertyOffset_FloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)FFloatCurve.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x000D4B10 File Offset: 0x000D2D10
		public FFloatCurve()
		{
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x000D4B18 File Offset: 0x000D2D18
		public FFloatCurve(FRichCurve FloatCurve, FName LastObservedName_DEPRECATED, FSmartName Name, FLinearColor Color, int CurveTypeFlags)
		{
			this.FloatCurve = FloatCurve;
			base.LastObservedName_DEPRECATED = LastObservedName_DEPRECATED;
			base.Name = Name;
			base.CurveTypeFlags = CurveTypeFlags;
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x000D4B3D File Offset: 0x000D2D3D
		protected override IntPtr GetUStructPtr()
		{
			return FFloatCurve.StaticStruct();
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x000D4B49 File Offset: 0x000D2D49
		[NullableContext(2)]
		public FFloatCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x000D4B53 File Offset: 0x000D2D53
		public FFloatCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x000D4B5E File Offset: 0x000D2D5E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFloatCurve(Pointer, false, true);
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x000D4B68 File Offset: 0x000D2D68
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFloatCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040053AA RID: 21418
		public new const string __ObjectPath = "/Script/Engine.FloatCurve";

		// Token: 0x040053AB RID: 21419
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053AC RID: 21420
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x040053AD RID: 21421
		[Nullable(2)]
		private FRichCurve _FloatCurve;
	}
}
