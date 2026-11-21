using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000562 RID: 1378
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffId")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_BuffId : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DAF RID: 32175 RVA: 0x000BA5F3 File Offset: 0x000B87F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffId._ClassPtr;
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x000BA600 File Offset: 0x000B8800
		public UKSC_BuffId() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffId.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DB1 RID: 32177 RVA: 0x000BA628 File Offset: 0x000B8828
		public UKSC_BuffId(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x000BA65C File Offset: 0x000B885C
		// (set) Token: 0x06007DB3 RID: 32179 RVA: 0x000BA695 File Offset: 0x000B8895
		public TMap<int, UKSC_DA_Buff> BuffDa
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKSC_DA_Buff> result;
				if ((result = this._BuffDa) == null)
				{
					result = (this._BuffDa = new TMap<int, UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_BuffId.__PropertyOffset_BuffDa, this));
				}
				return result;
			}
			set
			{
				this.BuffDa.CopyAssign(value);
			}
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x000BA6A3 File Offset: 0x000B88A3
		public void ClearBuffDA()
		{
			UKSC_BuffId.__ClearBuffDA_Internal(base.NativePtr);
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x000BA6B0 File Offset: 0x000B88B0
		[NullableContext(2)]
		public void AddBuffDA(long BuffId, UKSC_DA_Buff Data)
		{
			UKSC_BuffId.__AddBuffDA_Internal(base.NativePtr, BuffId, (Data != null) ? Data.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007DB6 RID: 32182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearBuffDA_Internal(IntPtr @this);

		// Token: 0x06007DB7 RID: 32183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddBuffDA_Internal(IntPtr @this, long BuffId, IntPtr Data);

		// Token: 0x06007DB8 RID: 32184 RVA: 0x000BA6CE File Offset: 0x000B88CE
		static UKSC_BuffId()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffId");
		}

		// Token: 0x06007DB9 RID: 32185 RVA: 0x000BA6DC File Offset: 0x000B88DC
		protected UKSC_BuffId(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036C5 RID: 14021
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffId";

		// Token: 0x040036C6 RID: 14022
		private static IntPtr _ClassPtr;

		// Token: 0x040036C7 RID: 14023
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036C8 RID: 14024
		internal static int __PropertyOffset_BuffDa;

		// Token: 0x040036C9 RID: 14025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKSC_DA_Buff> _BuffDa;
	}
}
