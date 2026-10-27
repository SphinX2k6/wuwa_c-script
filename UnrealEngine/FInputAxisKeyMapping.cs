using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C54 RID: 3156
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputAxisKeyMapping")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInputAxisKeyMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009FFC RID: 40956 RVA: 0x000E3616 File Offset: 0x000E1816
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputAxisKeyMapping._ScriptStructPtr != 0) ? FInputAxisKeyMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputAxisKeyMapping", ref FInputAxisKeyMapping._ScriptStructPtr);
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06009FFD RID: 40957 RVA: 0x000E363A File Offset: 0x000E183A
		// (set) Token: 0x06009FFE RID: 40958 RVA: 0x000E364E File Offset: 0x000E184E
		public unsafe FName AxisName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_AxisName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_AxisName) = value;
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06009FFF RID: 40959 RVA: 0x000E3663 File Offset: 0x000E1863
		// (set) Token: 0x0600A000 RID: 40960 RVA: 0x000E3673 File Offset: 0x000E1873
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x0600A001 RID: 40961 RVA: 0x000E3684 File Offset: 0x000E1884
		// (set) Token: 0x0600A002 RID: 40962 RVA: 0x000E36C7 File Offset: 0x000E18C7
		public FKey Key
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._Key) == null)
				{
					result = (this._Key = new FKey(base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Key, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FInputAxisKeyMapping.__PropertyOffset_Key, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x000E36E8 File Offset: 0x000E18E8
		public FInputAxisKeyMapping()
		{
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x000E36F0 File Offset: 0x000E18F0
		public FInputAxisKeyMapping(FName AxisName, float Scale, FKey Key)
		{
			this.AxisName = AxisName;
			this.Scale = Scale;
			this.Key = Key;
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x000E370D File Offset: 0x000E190D
		protected override IntPtr GetUStructPtr()
		{
			return FInputAxisKeyMapping.StaticStruct();
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x000E3719 File Offset: 0x000E1919
		[NullableContext(2)]
		public FInputAxisKeyMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x000E3723 File Offset: 0x000E1923
		public FInputAxisKeyMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x000E372E File Offset: 0x000E192E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputAxisKeyMapping(Pointer, false, true);
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x000E3738 File Offset: 0x000E1938
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputAxisKeyMapping(Pointer, MemoryOwner);
		}

		// Token: 0x0400580A RID: 22538
		public const string __ObjectPath = "/Script/Engine.InputAxisKeyMapping";

		// Token: 0x0400580B RID: 22539
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400580C RID: 22540
		internal static int __PropertyOffset_AxisName;

		// Token: 0x0400580D RID: 22541
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400580E RID: 22542
		internal static int __PropertyOffset_Key;

		// Token: 0x0400580F RID: 22543
		[Nullable(2)]
		private FKey _Key;
	}
}
