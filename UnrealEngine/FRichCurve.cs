using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000271 RID: 625
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RichCurve")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRichCurve : FRealCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004032 RID: 16434 RVA: 0x0005C1C8 File Offset: 0x0005A3C8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRichCurve._ScriptStructPtr != 0) ? FRichCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RichCurve", ref FRichCurve._ScriptStructPtr);
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x0005C1EC File Offset: 0x0005A3EC
		// (set) Token: 0x06004034 RID: 16436 RVA: 0x0005C22F File Offset: 0x0005A42F
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

		// Token: 0x06004035 RID: 16437 RVA: 0x0005C23D File Offset: 0x0005A43D
		public FRichCurve()
		{
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0005C245 File Offset: 0x0005A445
		protected override IntPtr GetUStructPtr()
		{
			return FRichCurve.StaticStruct();
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x0005C251 File Offset: 0x0005A451
		[NullableContext(2)]
		public FRichCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x0005C25B File Offset: 0x0005A45B
		public FRichCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x0005C266 File Offset: 0x0005A466
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRichCurve(Pointer, false, true);
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x0005C270 File Offset: 0x0005A470
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRichCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400191C RID: 6428
		public new const string __ObjectPath = "/Script/Engine.RichCurve";

		// Token: 0x0400191D RID: 6429
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400191E RID: 6430
		internal static int __PropertyOffset_Keys;

		// Token: 0x0400191F RID: 6431
		[Nullable(2)]
		private TArray<FRichCurveKey> _Keys;
	}
}
