using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CBC RID: 3260
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ISMBoundCheckConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FISMBoundCheckConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4D3 RID: 42195 RVA: 0x000EA8A4 File Offset: 0x000E8AA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMBoundCheckConfig._ScriptStructPtr != 0) ? FISMBoundCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMBoundCheckConfig", ref FISMBoundCheckConfig._ScriptStructPtr);
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x000EA8C8 File Offset: 0x000E8AC8
		// (set) Token: 0x0600A4D5 RID: 42197 RVA: 0x000EA8DC File Offset: 0x000E8ADC
		public unsafe string Key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FISMBoundCheckConfig.__PropertyOffset_Key)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FISMBoundCheckConfig.__PropertyOffset_Key)), value);
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x000EA8F1 File Offset: 0x000E8AF1
		// (set) Token: 0x0600A4D7 RID: 42199 RVA: 0x000EA901 File Offset: 0x000E8B01
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FISMBoundCheckConfig.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FISMBoundCheckConfig.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x000EA912 File Offset: 0x000E8B12
		public FISMBoundCheckConfig()
		{
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x000EA91A File Offset: 0x000E8B1A
		public FISMBoundCheckConfig(string Key, float Value)
		{
			this.Key = Key;
			this.Value = Value;
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x000EA930 File Offset: 0x000E8B30
		protected override IntPtr GetUStructPtr()
		{
			return FISMBoundCheckConfig.StaticStruct();
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x000EA93C File Offset: 0x000E8B3C
		[NullableContext(2)]
		public FISMBoundCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x000EA946 File Offset: 0x000E8B46
		public FISMBoundCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x000EA951 File Offset: 0x000E8B51
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMBoundCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x000EA95B File Offset: 0x000E8B5B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMBoundCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005AB9 RID: 23225
		public const string __ObjectPath = "/Script/Engine.ISMBoundCheckConfig";

		// Token: 0x04005ABA RID: 23226
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005ABB RID: 23227
		internal static int __PropertyOffset_Key;

		// Token: 0x04005ABC RID: 23228
		internal static int __PropertyOffset_Value;
	}
}
