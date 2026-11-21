using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200020C RID: 524
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ExtraMaterialInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FExtraMaterialInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060021A9 RID: 8617 RVA: 0x00031559 File Offset: 0x0002F759
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtraMaterialInfo._ScriptStructPtr != 0) ? FExtraMaterialInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExtraMaterialInfo", ref FExtraMaterialInfo._ScriptStructPtr);
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x00031580 File Offset: 0x0002F780
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x000315C3 File Offset: 0x0002F7C3
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

		// Token: 0x060021AC RID: 8620 RVA: 0x000315D1 File Offset: 0x0002F7D1
		public FExtraMaterialInfo()
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000315D9 File Offset: 0x0002F7D9
		protected override IntPtr GetUStructPtr()
		{
			return FExtraMaterialInfo.StaticStruct();
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000315E5 File Offset: 0x0002F7E5
		[NullableContext(2)]
		public FExtraMaterialInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000315EF File Offset: 0x0002F7EF
		public FExtraMaterialInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000315FA File Offset: 0x0002F7FA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtraMaterialInfo(Pointer, false, true);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00031604 File Offset: 0x0002F804
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtraMaterialInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000D23 RID: 3363
		public const string __ObjectPath = "/Script/Engine.ExtraMaterialInfo";

		// Token: 0x04000D24 RID: 3364
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000D25 RID: 3365
		internal static int __PropertyOffset_MaterialIndexs;

		// Token: 0x04000D26 RID: 3366
		[Nullable(2)]
		private TArray<int> _MaterialIndexs;
	}
}
