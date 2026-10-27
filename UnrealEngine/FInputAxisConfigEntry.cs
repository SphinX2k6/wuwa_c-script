using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C51 RID: 3153
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputAxisConfigEntry")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FInputAxisConfigEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009FE2 RID: 40930 RVA: 0x000E3381 File Offset: 0x000E1581
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputAxisConfigEntry._ScriptStructPtr != 0) ? FInputAxisConfigEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputAxisConfigEntry", ref FInputAxisConfigEntry._ScriptStructPtr);
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06009FE3 RID: 40931 RVA: 0x000E33A5 File Offset: 0x000E15A5
		// (set) Token: 0x06009FE4 RID: 40932 RVA: 0x000E33B9 File Offset: 0x000E15B9
		public unsafe FName AxisKeyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisConfigEntry.__PropertyOffset_AxisKeyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisConfigEntry.__PropertyOffset_AxisKeyName) = value;
			}
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06009FE5 RID: 40933 RVA: 0x000E33D0 File Offset: 0x000E15D0
		// (set) Token: 0x06009FE6 RID: 40934 RVA: 0x000E3413 File Offset: 0x000E1613
		public FInputAxisProperties AxisProperties
		{
			get
			{
				base.FastCheckIsValid();
				FInputAxisProperties result;
				if ((result = this._AxisProperties) == null)
				{
					result = (this._AxisProperties = new FInputAxisProperties(base.NativePtr + (IntPtr)FInputAxisConfigEntry.__PropertyOffset_AxisProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputAxisProperties.StaticStruct(), base.NativePtr + (IntPtr)FInputAxisConfigEntry.__PropertyOffset_AxisProperties, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x000E3434 File Offset: 0x000E1634
		public FInputAxisConfigEntry()
		{
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x000E343C File Offset: 0x000E163C
		public FInputAxisConfigEntry(FName AxisKeyName, FInputAxisProperties AxisProperties)
		{
			this.AxisKeyName = AxisKeyName;
			this.AxisProperties = AxisProperties;
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x000E3452 File Offset: 0x000E1652
		protected override IntPtr GetUStructPtr()
		{
			return FInputAxisConfigEntry.StaticStruct();
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x000E345E File Offset: 0x000E165E
		[NullableContext(2)]
		public FInputAxisConfigEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x000E3468 File Offset: 0x000E1668
		public FInputAxisConfigEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x000E3473 File Offset: 0x000E1673
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputAxisConfigEntry(Pointer, false, true);
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x000E347D File Offset: 0x000E167D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputAxisConfigEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040057FB RID: 22523
		public const string __ObjectPath = "/Script/Engine.InputAxisConfigEntry";

		// Token: 0x040057FC RID: 22524
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057FD RID: 22525
		internal static int __PropertyOffset_AxisKeyName;

		// Token: 0x040057FE RID: 22526
		internal static int __PropertyOffset_AxisProperties;

		// Token: 0x040057FF RID: 22527
		[Nullable(2)]
		private FInputAxisProperties _AxisProperties;
	}
}
