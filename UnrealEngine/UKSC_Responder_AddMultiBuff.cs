using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E1D RID: 7709
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_AddMultiBuff")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Responder_AddMultiBuff : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D672 RID: 120434 RVA: 0x002B6DDB File Offset: 0x002B4FDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_AddMultiBuff._ClassPtr;
		}

		// Token: 0x0601D673 RID: 120435 RVA: 0x002B6DE8 File Offset: 0x002B4FE8
		public UKSC_Responder_AddMultiBuff() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AddMultiBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D674 RID: 120436 RVA: 0x002B6E10 File Offset: 0x002B5010
		public UKSC_Responder_AddMultiBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AddMultiBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700768D RID: 30349
		// (get) Token: 0x0601D675 RID: 120437 RVA: 0x002B6E44 File Offset: 0x002B5044
		// (set) Token: 0x0601D676 RID: 120438 RVA: 0x002B6E7D File Offset: 0x002B507D
		public TArray<UKSC_DA_Buff> BuffsToAdd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._BuffsToAdd) == null)
				{
					result = (this._BuffsToAdd = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_Responder_AddMultiBuff.__PropertyOffset_BuffsToAdd, this));
				}
				return result;
			}
			set
			{
				this.BuffsToAdd.CopyAssign(value);
			}
		}

		// Token: 0x0601D677 RID: 120439 RVA: 0x002B6E8B File Offset: 0x002B508B
		static UKSC_Responder_AddMultiBuff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_AddMultiBuff");
		}

		// Token: 0x0601D678 RID: 120440 RVA: 0x002B6E99 File Offset: 0x002B5099
		protected UKSC_Responder_AddMultiBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF14 RID: 65300
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_AddMultiBuff";

		// Token: 0x0400FF15 RID: 65301
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF16 RID: 65302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF17 RID: 65303
		internal static int __PropertyOffset_BuffsToAdd;

		// Token: 0x0400FF18 RID: 65304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _BuffsToAdd;
	}
}
