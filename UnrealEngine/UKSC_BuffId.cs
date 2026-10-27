using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D05 RID: 7429
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffId")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_BuffId : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C922 RID: 117026 RVA: 0x002A3C96 File Offset: 0x002A1E96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffId._ClassPtr;
		}

		// Token: 0x0601C923 RID: 117027 RVA: 0x002A3CA4 File Offset: 0x002A1EA4
		public UKSC_BuffId() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffId.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C924 RID: 117028 RVA: 0x002A3CCC File Offset: 0x002A1ECC
		public UKSC_BuffId(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007315 RID: 29461
		// (get) Token: 0x0601C925 RID: 117029 RVA: 0x002A3D00 File Offset: 0x002A1F00
		// (set) Token: 0x0601C926 RID: 117030 RVA: 0x002A3D39 File Offset: 0x002A1F39
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

		// Token: 0x0601C927 RID: 117031 RVA: 0x002A3D47 File Offset: 0x002A1F47
		public void ClearBuffDA()
		{
			UKSC_BuffId.__ClearBuffDA_Internal(base.NativePtr);
		}

		// Token: 0x0601C928 RID: 117032 RVA: 0x002A3D54 File Offset: 0x002A1F54
		[NullableContext(2)]
		public void AddBuffDA(long BuffId, UKSC_DA_Buff Data)
		{
			UKSC_BuffId.__AddBuffDA_Internal(base.NativePtr, BuffId, (Data != null) ? Data.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601C929 RID: 117033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearBuffDA_Internal(IntPtr @this);

		// Token: 0x0601C92A RID: 117034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddBuffDA_Internal(IntPtr @this, long BuffId, IntPtr Data);

		// Token: 0x0601C92B RID: 117035 RVA: 0x002A3D72 File Offset: 0x002A1F72
		static UKSC_BuffId()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffId");
		}

		// Token: 0x0601C92C RID: 117036 RVA: 0x002A3D80 File Offset: 0x002A1F80
		protected UKSC_BuffId(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7CD RID: 63437
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffId";

		// Token: 0x0400F7CE RID: 63438
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7CF RID: 63439
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7D0 RID: 63440
		internal static int __PropertyOffset_BuffDa;

		// Token: 0x0400F7D1 RID: 63441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKSC_DA_Buff> _BuffDa;
	}
}
