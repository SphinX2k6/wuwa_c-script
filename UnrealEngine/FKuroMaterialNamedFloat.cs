using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B69 RID: 7017
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloat")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroMaterialNamedFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A8F6 RID: 108790 RVA: 0x00272982 File Offset: 0x00270B82
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedFloat._ScriptStructPtr != 0) ? FKuroMaterialNamedFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloat", ref FKuroMaterialNamedFloat._ScriptStructPtr);
		}

		// Token: 0x17006ABB RID: 27323
		// (get) Token: 0x0601A8F7 RID: 108791 RVA: 0x002729A6 File Offset: 0x00270BA6
		// (set) Token: 0x0601A8F8 RID: 108792 RVA: 0x002729BA File Offset: 0x00270BBA
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006ABC RID: 27324
		// (get) Token: 0x0601A8F9 RID: 108793 RVA: 0x002729CF File Offset: 0x00270BCF
		// (set) Token: 0x0601A8FA RID: 108794 RVA: 0x002729DF File Offset: 0x00270BDF
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0601A8FB RID: 108795 RVA: 0x002729F0 File Offset: 0x00270BF0
		public FKuroMaterialNamedFloat()
		{
		}

		// Token: 0x0601A8FC RID: 108796 RVA: 0x002729F8 File Offset: 0x00270BF8
		public FKuroMaterialNamedFloat(FName Name, float Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601A8FD RID: 108797 RVA: 0x00272A0E File Offset: 0x00270C0E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedFloat.StaticStruct();
		}

		// Token: 0x0601A8FE RID: 108798 RVA: 0x00272A1A File Offset: 0x00270C1A
		[NullableContext(2)]
		public FKuroMaterialNamedFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8FF RID: 108799 RVA: 0x00272A24 File Offset: 0x00270C24
		public FKuroMaterialNamedFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A900 RID: 108800 RVA: 0x00272A2F File Offset: 0x00270C2F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedFloat(Pointer, false, true);
		}

		// Token: 0x0601A901 RID: 108801 RVA: 0x00272A39 File Offset: 0x00270C39
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400E61D RID: 58909
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedFloat";

		// Token: 0x0400E61E RID: 58910
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E61F RID: 58911
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E620 RID: 58912
		internal static int __PropertyOffset_Value;
	}
}
