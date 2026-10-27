using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008EA RID: 2282
	[UnrealObjectPath("/Script/Engine.BPComponentClassOverride")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBPComponentClassOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D2B RID: 32043 RVA: 0x000B36C5 File Offset: 0x000B18C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBPComponentClassOverride._ScriptStructPtr != 0) ? FBPComponentClassOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BPComponentClassOverride", ref FBPComponentClassOverride._ScriptStructPtr);
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06007D2C RID: 32044 RVA: 0x000B36E9 File Offset: 0x000B18E9
		// (set) Token: 0x06007D2D RID: 32045 RVA: 0x000B36FD File Offset: 0x000B18FD
		public unsafe FName ComponentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPComponentClassOverride.__PropertyOffset_ComponentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPComponentClassOverride.__PropertyOffset_ComponentName) = value;
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06007D2E RID: 32046 RVA: 0x000B3712 File Offset: 0x000B1912
		// (set) Token: 0x06007D2F RID: 32047 RVA: 0x000B3726 File Offset: 0x000B1926
		public unsafe UClassStackOnlyPtr ComponentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPComponentClassOverride.__PropertyOffset_ComponentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPComponentClassOverride.__PropertyOffset_ComponentClass) = value;
			}
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x000B373B File Offset: 0x000B193B
		public FBPComponentClassOverride()
		{
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x000B3743 File Offset: 0x000B1943
		public FBPComponentClassOverride(FName ComponentName, UClassStackOnlyPtr ComponentClass)
		{
			this.ComponentName = ComponentName;
			this.ComponentClass = ComponentClass;
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x000B3759 File Offset: 0x000B1959
		protected override IntPtr GetUStructPtr()
		{
			return FBPComponentClassOverride.StaticStruct();
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x000B3765 File Offset: 0x000B1965
		[NullableContext(2)]
		public FBPComponentClassOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x000B376F File Offset: 0x000B196F
		public FBPComponentClassOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x000B377A File Offset: 0x000B197A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBPComponentClassOverride(Pointer, false, true);
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x000B3784 File Offset: 0x000B1984
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBPComponentClassOverride(Pointer, MemoryOwner);
		}

		// Token: 0x04003BFD RID: 15357
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BPComponentClassOverride";

		// Token: 0x04003BFE RID: 15358
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BFF RID: 15359
		internal static int __PropertyOffset_ComponentName;

		// Token: 0x04003C00 RID: 15360
		internal static int __PropertyOffset_ComponentClass;
	}
}
