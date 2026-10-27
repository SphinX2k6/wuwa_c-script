using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200100D RID: 4109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlayerInput")]
	[UnrealStructLayout(944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 944)]
	public class UPlayerInput : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E096 RID: 57494 RVA: 0x0014A4E9 File Offset: 0x001486E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlayerInput._ClassPtr;
		}

		// Token: 0x0600E097 RID: 57495 RVA: 0x0014A4F8 File Offset: 0x001486F8
		public UPlayerInput() : this(BuiltinUtils.AllocNativeUObject(UPlayerInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E098 RID: 57496 RVA: 0x0014A520 File Offset: 0x00148720
		public UPlayerInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlayerInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600E099 RID: 57497 RVA: 0x0014A554 File Offset: 0x00148754
		// (set) Token: 0x0600E09A RID: 57498 RVA: 0x0014A58D File Offset: 0x0014878D
		public TArray<FKeyBind> DebugExecBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKeyBind> result;
				if ((result = this._DebugExecBindings) == null)
				{
					result = (this._DebugExecBindings = new TArray<FKeyBind>(base.NativePtr + (IntPtr)UPlayerInput.__PropertyOffset_DebugExecBindings, this));
				}
				return result;
			}
			set
			{
				this.DebugExecBindings.CopyAssign(value);
			}
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x0600E09B RID: 57499 RVA: 0x0014A59C File Offset: 0x0014879C
		// (set) Token: 0x0600E09C RID: 57500 RVA: 0x0014A5D5 File Offset: 0x001487D5
		public TArray<FName> InvertedAxis
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InvertedAxis) == null)
				{
					result = (this._InvertedAxis = new TArray<FName>(base.NativePtr + (IntPtr)UPlayerInput.__PropertyOffset_InvertedAxis, this));
				}
				return result;
			}
			set
			{
				this.InvertedAxis.CopyAssign(value);
			}
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x0014A5E3 File Offset: 0x001487E3
		public void SetMouseSensitivity(float Sensitivity)
		{
			UPlayerInput.__SetMouseSensitivity_Internal(base.NativePtr, Sensitivity);
		}

		// Token: 0x0600E09E RID: 57502 RVA: 0x0014A5F4 File Offset: 0x001487F4
		public unsafe void SetBind(FName BindName, string Command)
		{
			FString fstring = FString.AllocTemp(Command);
			UPlayerInput.__SetBind_Internal(base.NativePtr, BindName, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600E09F RID: 57503 RVA: 0x0014A61F File Offset: 0x0014881F
		[NullableContext(2)]
		public void InvertAxisKey(FKey AxisKey)
		{
			UPlayerInput.__InvertAxisKey_Internal(base.NativePtr, (AxisKey ?? new FKey()).NativePtr);
		}

		// Token: 0x0600E0A0 RID: 57504 RVA: 0x0014A63B File Offset: 0x0014883B
		public void InvertAxis(FName AxisName)
		{
			UPlayerInput.__InvertAxis_Internal(base.NativePtr, AxisName);
		}

		// Token: 0x0600E0A1 RID: 57505 RVA: 0x0014A649 File Offset: 0x00148849
		public void ClearSmoothing()
		{
			UPlayerInput.__ClearSmoothing_Internal(base.NativePtr);
		}

		// Token: 0x0600E0A2 RID: 57506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMouseSensitivity_Internal(IntPtr @this, float Sensitivity);

		// Token: 0x0600E0A3 RID: 57507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBind_Internal(IntPtr @this, FName BindName, in FString Command);

		// Token: 0x0600E0A4 RID: 57508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvertAxisKey_Internal(IntPtr @this, IntPtr AxisKey);

		// Token: 0x0600E0A5 RID: 57509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvertAxis_Internal(IntPtr @this, FName AxisName);

		// Token: 0x0600E0A6 RID: 57510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSmoothing_Internal(IntPtr @this);

		// Token: 0x0600E0A7 RID: 57511 RVA: 0x0014A656 File Offset: 0x00148856
		static UPlayerInput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerInput");
		}

		// Token: 0x0600E0A8 RID: 57512 RVA: 0x0014A664 File Offset: 0x00148864
		protected UPlayerInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040078AC RID: 30892
		public new const string __ObjectPath = "/Script/Engine.PlayerInput";

		// Token: 0x040078AD RID: 30893
		private static IntPtr _ClassPtr;

		// Token: 0x040078AE RID: 30894
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040078AF RID: 30895
		internal static int __PropertyOffset_DebugExecBindings;

		// Token: 0x040078B0 RID: 30896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKeyBind> _DebugExecBindings;

		// Token: 0x040078B1 RID: 30897
		internal static int __PropertyOffset_InvertedAxis;

		// Token: 0x040078B2 RID: 30898
		[Nullable(2)]
		private TArray<FName> _InvertedAxis;
	}
}
