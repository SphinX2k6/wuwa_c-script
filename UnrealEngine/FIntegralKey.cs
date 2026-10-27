using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C6E RID: 3182
	[UnrealObjectPath("/Script/Engine.IntegralKey")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FIntegralKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A1E3 RID: 41443 RVA: 0x000E5ED8 File Offset: 0x000E40D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntegralKey._ScriptStructPtr != 0) ? FIntegralKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.IntegralKey", ref FIntegralKey._ScriptStructPtr);
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x0600A1E4 RID: 41444 RVA: 0x000E5EFC File Offset: 0x000E40FC
		// (set) Token: 0x0600A1E5 RID: 41445 RVA: 0x000E5F0C File Offset: 0x000E410C
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIntegralKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIntegralKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600A1E6 RID: 41446 RVA: 0x000E5F1D File Offset: 0x000E411D
		// (set) Token: 0x0600A1E7 RID: 41447 RVA: 0x000E5F2D File Offset: 0x000E412D
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIntegralKey.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIntegralKey.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x000E5F3E File Offset: 0x000E413E
		public FIntegralKey()
		{
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x000E5F46 File Offset: 0x000E4146
		public FIntegralKey(float Time, int Value)
		{
			this.Time = Time;
			this.Value = Value;
		}

		// Token: 0x0600A1EA RID: 41450 RVA: 0x000E5F5C File Offset: 0x000E415C
		protected override IntPtr GetUStructPtr()
		{
			return FIntegralKey.StaticStruct();
		}

		// Token: 0x0600A1EB RID: 41451 RVA: 0x000E5F68 File Offset: 0x000E4168
		[NullableContext(2)]
		public FIntegralKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x000E5F72 File Offset: 0x000E4172
		public FIntegralKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x000E5F7D File Offset: 0x000E417D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIntegralKey(Pointer, false, true);
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x000E5F87 File Offset: 0x000E4187
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIntegralKey(Pointer, MemoryOwner);
		}

		// Token: 0x040058D9 RID: 22745
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.IntegralKey";

		// Token: 0x040058DA RID: 22746
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058DB RID: 22747
		internal static int __PropertyOffset_Time;

		// Token: 0x040058DC RID: 22748
		internal static int __PropertyOffset_Value;
	}
}
