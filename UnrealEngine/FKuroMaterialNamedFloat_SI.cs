using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B6B RID: 7019
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloat_SI")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroMaterialNamedFloat_SI : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A90E RID: 108814 RVA: 0x00272B46 File Offset: 0x00270D46
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedFloat_SI._ScriptStructPtr != 0) ? FKuroMaterialNamedFloat_SI._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloat_SI", ref FKuroMaterialNamedFloat_SI._ScriptStructPtr);
		}

		// Token: 0x17006ABF RID: 27327
		// (get) Token: 0x0601A90F RID: 108815 RVA: 0x00272B6A File Offset: 0x00270D6A
		// (set) Token: 0x0601A910 RID: 108816 RVA: 0x00272B7E File Offset: 0x00270D7E
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat_SI.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat_SI.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006AC0 RID: 27328
		// (get) Token: 0x0601A911 RID: 108817 RVA: 0x00272B93 File Offset: 0x00270D93
		// (set) Token: 0x0601A912 RID: 108818 RVA: 0x00272BA3 File Offset: 0x00270DA3
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat_SI.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat_SI.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0601A913 RID: 108819 RVA: 0x00272BB4 File Offset: 0x00270DB4
		public FKuroMaterialNamedFloat_SI()
		{
		}

		// Token: 0x0601A914 RID: 108820 RVA: 0x00272BBC File Offset: 0x00270DBC
		public FKuroMaterialNamedFloat_SI(FName Name, float Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601A915 RID: 108821 RVA: 0x00272BD2 File Offset: 0x00270DD2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedFloat_SI.StaticStruct();
		}

		// Token: 0x0601A916 RID: 108822 RVA: 0x00272BDE File Offset: 0x00270DDE
		[NullableContext(2)]
		public FKuroMaterialNamedFloat_SI(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A917 RID: 108823 RVA: 0x00272BE8 File Offset: 0x00270DE8
		public FKuroMaterialNamedFloat_SI(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A918 RID: 108824 RVA: 0x00272BF3 File Offset: 0x00270DF3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedFloat_SI(Pointer, false, true);
		}

		// Token: 0x0601A919 RID: 108825 RVA: 0x00272BFD File Offset: 0x00270DFD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedFloat_SI(Pointer, MemoryOwner);
		}

		// Token: 0x0400E626 RID: 58918
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloat_SI";

		// Token: 0x0400E627 RID: 58919
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E628 RID: 58920
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E629 RID: 58921
		internal static int __PropertyOffset_Value;
	}
}
