using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004D5 RID: 1237
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigSettingsPerPinBool")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FControlRigSettingsPerPinBool : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004265 RID: 16997 RVA: 0x000633C6 File Offset: 0x000615C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigSettingsPerPinBool._ScriptStructPtr != 0) ? FControlRigSettingsPerPinBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigSettingsPerPinBool", ref FControlRigSettingsPerPinBool._ScriptStructPtr);
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06004266 RID: 16998 RVA: 0x000633EC File Offset: 0x000615EC
		// (set) Token: 0x06004267 RID: 16999 RVA: 0x0006342F File Offset: 0x0006162F
		public TMap<string, bool> Values
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, bool> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TMap<string, bool>(base.NativePtr + (IntPtr)FControlRigSettingsPerPinBool.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0006343D File Offset: 0x0006163D
		public FControlRigSettingsPerPinBool()
		{
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x00063445 File Offset: 0x00061645
		public FControlRigSettingsPerPinBool(TMap<string, bool> Values)
		{
			this.Values = Values;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00063454 File Offset: 0x00061654
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigSettingsPerPinBool.StaticStruct();
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00063460 File Offset: 0x00061660
		[NullableContext(2)]
		public FControlRigSettingsPerPinBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x0006346A File Offset: 0x0006166A
		public FControlRigSettingsPerPinBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x00063475 File Offset: 0x00061675
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigSettingsPerPinBool(Pointer, false, true);
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x0006347F File Offset: 0x0006167F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigSettingsPerPinBool(Pointer, MemoryOwner);
		}

		// Token: 0x04001F8E RID: 8078
		public const string __ObjectPath = "/Script/ControlRig.ControlRigSettingsPerPinBool";

		// Token: 0x04001F8F RID: 8079
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F90 RID: 8080
		internal static int __PropertyOffset_Values;

		// Token: 0x04001F91 RID: 8081
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, bool> _Values;
	}
}
