using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001ACA RID: 6858
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMatNamedFloatParam")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroCharWetMatNamedFloatParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060197D8 RID: 104408 RVA: 0x0025AA33 File Offset: 0x00258C33
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharWetMatNamedFloatParam._ScriptStructPtr != 0) ? FKuroCharWetMatNamedFloatParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMatNamedFloatParam", ref FKuroCharWetMatNamedFloatParam._ScriptStructPtr);
		}

		// Token: 0x170065A2 RID: 26018
		// (get) Token: 0x060197D9 RID: 104409 RVA: 0x0025AA57 File Offset: 0x00258C57
		// (set) Token: 0x060197DA RID: 104410 RVA: 0x0025AA6B File Offset: 0x00258C6B
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharWetMatNamedFloatParam.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharWetMatNamedFloatParam.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170065A3 RID: 26019
		// (get) Token: 0x060197DB RID: 104411 RVA: 0x0025AA80 File Offset: 0x00258C80
		// (set) Token: 0x060197DC RID: 104412 RVA: 0x0025AA90 File Offset: 0x00258C90
		public unsafe float WetValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCharWetMatNamedFloatParam.__PropertyOffset_WetValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCharWetMatNamedFloatParam.__PropertyOffset_WetValue) = value;
			}
		}

		// Token: 0x060197DD RID: 104413 RVA: 0x0025AAA1 File Offset: 0x00258CA1
		public FKuroCharWetMatNamedFloatParam()
		{
		}

		// Token: 0x060197DE RID: 104414 RVA: 0x0025AAA9 File Offset: 0x00258CA9
		public FKuroCharWetMatNamedFloatParam(FName Name, float WetValue)
		{
			this.Name = Name;
			this.WetValue = WetValue;
		}

		// Token: 0x060197DF RID: 104415 RVA: 0x0025AABF File Offset: 0x00258CBF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharWetMatNamedFloatParam.StaticStruct();
		}

		// Token: 0x060197E0 RID: 104416 RVA: 0x0025AACB File Offset: 0x00258CCB
		[NullableContext(2)]
		public FKuroCharWetMatNamedFloatParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060197E1 RID: 104417 RVA: 0x0025AAD5 File Offset: 0x00258CD5
		public FKuroCharWetMatNamedFloatParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060197E2 RID: 104418 RVA: 0x0025AAE0 File Offset: 0x00258CE0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharWetMatNamedFloatParam(Pointer, false, true);
		}

		// Token: 0x060197E3 RID: 104419 RVA: 0x0025AAEA File Offset: 0x00258CEA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharWetMatNamedFloatParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDF7 RID: 56823
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetMatNamedFloatParam";

		// Token: 0x0400DDF8 RID: 56824
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDF9 RID: 56825
		internal static int __PropertyOffset_Name;

		// Token: 0x0400DDFA RID: 56826
		internal static int __PropertyOffset_WetValue;
	}
}
