using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D8B RID: 7563
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Decorator")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_Decorator : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF39 RID: 118585 RVA: 0x002ACB01 File Offset: 0x002AAD01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Decorator._ClassPtr;
		}

		// Token: 0x0601CF3A RID: 118586 RVA: 0x002ACB10 File Offset: 0x002AAD10
		public UKSC_DA_Decorator() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Decorator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF3B RID: 118587 RVA: 0x002ACB38 File Offset: 0x002AAD38
		public UKSC_DA_Decorator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Decorator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074C6 RID: 29894
		// (get) Token: 0x0601CF3C RID: 118588 RVA: 0x002ACB6B File Offset: 0x002AAD6B
		// (set) Token: 0x0601CF3D RID: 118589 RVA: 0x002ACB7F File Offset: 0x002AAD7F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_Decorator> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Decorator.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Decorator.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x170074C7 RID: 29895
		// (get) Token: 0x0601CF3E RID: 118590 RVA: 0x002ACB94 File Offset: 0x002AAD94
		// (set) Token: 0x0601CF3F RID: 118591 RVA: 0x002ACBCD File Offset: 0x002AADCD
		public FKSC_TagFilter TagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._TagFilter) == null)
				{
					result = (this._TagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Decorator.__PropertyOffset_TagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Decorator.__PropertyOffset_TagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CF40 RID: 118592 RVA: 0x002ACBEE File Offset: 0x002AADEE
		static UKSC_DA_Decorator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Decorator");
		}

		// Token: 0x0601CF41 RID: 118593 RVA: 0x002ACBFC File Offset: 0x002AADFC
		protected UKSC_DA_Decorator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB66 RID: 64358
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Decorator";

		// Token: 0x0400FB67 RID: 64359
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB68 RID: 64360
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB69 RID: 64361
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400FB6A RID: 64362
		internal static int __PropertyOffset_TagFilter;

		// Token: 0x0400FB6B RID: 64363
		[Nullable(2)]
		private FKSC_TagFilter _TagFilter;
	}
}
