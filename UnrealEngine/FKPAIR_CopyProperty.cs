using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001650 RID: 5712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KPAIR_CopyProperty")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKPAIR_CopyProperty : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148FA RID: 84218 RVA: 0x001E3DF4 File Offset: 0x001E1FF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKPAIR_CopyProperty._ScriptStructPtr != 0) ? FKPAIR_CopyProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KPAIR_CopyProperty", ref FKPAIR_CopyProperty._ScriptStructPtr);
		}

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x060148FB RID: 84219 RVA: 0x001E3E18 File Offset: 0x001E2018
		// (set) Token: 0x060148FC RID: 84220 RVA: 0x001E3E5B File Offset: 0x001E205B
		public TArray<FName> InnerNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InnerNames) == null)
				{
					result = (this._InnerNames = new TArray<FName>(base.NativePtr + (IntPtr)FKPAIR_CopyProperty.__PropertyOffset_InnerNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InnerNames.CopyAssign(value);
			}
		}

		// Token: 0x060148FD RID: 84221 RVA: 0x001E3E69 File Offset: 0x001E2069
		public FKPAIR_CopyProperty()
		{
		}

		// Token: 0x060148FE RID: 84222 RVA: 0x001E3E71 File Offset: 0x001E2071
		public FKPAIR_CopyProperty(TArray<FName> InnerNames)
		{
			this.InnerNames = InnerNames;
		}

		// Token: 0x060148FF RID: 84223 RVA: 0x001E3E80 File Offset: 0x001E2080
		protected override IntPtr GetUStructPtr()
		{
			return FKPAIR_CopyProperty.StaticStruct();
		}

		// Token: 0x06014900 RID: 84224 RVA: 0x001E3E8C File Offset: 0x001E208C
		[NullableContext(2)]
		public FKPAIR_CopyProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014901 RID: 84225 RVA: 0x001E3E96 File Offset: 0x001E2096
		public FKPAIR_CopyProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014902 RID: 84226 RVA: 0x001E3EA1 File Offset: 0x001E20A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKPAIR_CopyProperty(Pointer, false, true);
		}

		// Token: 0x06014903 RID: 84227 RVA: 0x001E3EAB File Offset: 0x001E20AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKPAIR_CopyProperty(Pointer, MemoryOwner);
		}

		// Token: 0x0400B39E RID: 45982
		public const string __ObjectPath = "/Script/KuroAnim.KPAIR_CopyProperty";

		// Token: 0x0400B39F RID: 45983
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B3A0 RID: 45984
		internal static int __PropertyOffset_InnerNames;

		// Token: 0x0400B3A1 RID: 45985
		[Nullable(2)]
		private TArray<FName> _InnerNames;
	}
}
