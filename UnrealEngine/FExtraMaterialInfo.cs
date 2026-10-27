using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BD0 RID: 3024
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ExtraMaterialInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FExtraMaterialInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060094AE RID: 38062 RVA: 0x000D43B9 File Offset: 0x000D25B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtraMaterialInfo._ScriptStructPtr != 0) ? FExtraMaterialInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExtraMaterialInfo", ref FExtraMaterialInfo._ScriptStructPtr);
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x060094AF RID: 38063 RVA: 0x000D43E0 File Offset: 0x000D25E0
		// (set) Token: 0x060094B0 RID: 38064 RVA: 0x000D4423 File Offset: 0x000D2623
		public TArray<int> MaterialIndexs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MaterialIndexs) == null)
				{
					result = (this._MaterialIndexs = new TArray<int>(base.NativePtr + (IntPtr)FExtraMaterialInfo.__PropertyOffset_MaterialIndexs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialIndexs.CopyAssign(value);
			}
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x000D4431 File Offset: 0x000D2631
		public FExtraMaterialInfo()
		{
		}

		// Token: 0x060094B2 RID: 38066 RVA: 0x000D4439 File Offset: 0x000D2639
		public FExtraMaterialInfo(TArray<int> MaterialIndexs)
		{
			this.MaterialIndexs = MaterialIndexs;
		}

		// Token: 0x060094B3 RID: 38067 RVA: 0x000D4448 File Offset: 0x000D2648
		protected override IntPtr GetUStructPtr()
		{
			return FExtraMaterialInfo.StaticStruct();
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x000D4454 File Offset: 0x000D2654
		[NullableContext(2)]
		public FExtraMaterialInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x000D445E File Offset: 0x000D265E
		public FExtraMaterialInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x000D4469 File Offset: 0x000D2669
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtraMaterialInfo(Pointer, false, true);
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x000D4473 File Offset: 0x000D2673
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtraMaterialInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005384 RID: 21380
		public const string __ObjectPath = "/Script/Engine.ExtraMaterialInfo";

		// Token: 0x04005385 RID: 21381
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005386 RID: 21382
		internal static int __PropertyOffset_MaterialIndexs;

		// Token: 0x04005387 RID: 21383
		[Nullable(2)]
		private TArray<int> _MaterialIndexs;
	}
}
