using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028CA RID: 10442
	[UnrealObjectPath("/Script/StreamlineBlueprint.StreamlineVersion")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FStreamlineVersion : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026C22 RID: 158754 RVA: 0x003B20A0 File Offset: 0x003B02A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamlineVersion._ScriptStructPtr != 0) ? FStreamlineVersion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/StreamlineBlueprint.StreamlineVersion", ref FStreamlineVersion._ScriptStructPtr);
		}

		// Token: 0x17009551 RID: 38225
		// (get) Token: 0x06026C23 RID: 158755 RVA: 0x003B20C4 File Offset: 0x003B02C4
		// (set) Token: 0x06026C24 RID: 158756 RVA: 0x003B20D4 File Offset: 0x003B02D4
		public unsafe int Major
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamlineVersion.__PropertyOffset_Major);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamlineVersion.__PropertyOffset_Major) = value;
			}
		}

		// Token: 0x17009552 RID: 38226
		// (get) Token: 0x06026C25 RID: 158757 RVA: 0x003B20E5 File Offset: 0x003B02E5
		// (set) Token: 0x06026C26 RID: 158758 RVA: 0x003B20F5 File Offset: 0x003B02F5
		public unsafe int Minor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamlineVersion.__PropertyOffset_Minor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamlineVersion.__PropertyOffset_Minor) = value;
			}
		}

		// Token: 0x17009553 RID: 38227
		// (get) Token: 0x06026C27 RID: 158759 RVA: 0x003B2106 File Offset: 0x003B0306
		// (set) Token: 0x06026C28 RID: 158760 RVA: 0x003B2116 File Offset: 0x003B0316
		public unsafe int Build
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamlineVersion.__PropertyOffset_Build);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamlineVersion.__PropertyOffset_Build) = value;
			}
		}

		// Token: 0x06026C29 RID: 158761 RVA: 0x003B2127 File Offset: 0x003B0327
		public FStreamlineVersion()
		{
		}

		// Token: 0x06026C2A RID: 158762 RVA: 0x003B212F File Offset: 0x003B032F
		public FStreamlineVersion(int Major, int Minor, int Build)
		{
			this.Major = Major;
			this.Minor = Minor;
			this.Build = Build;
		}

		// Token: 0x06026C2B RID: 158763 RVA: 0x003B214C File Offset: 0x003B034C
		protected override IntPtr GetUStructPtr()
		{
			return FStreamlineVersion.StaticStruct();
		}

		// Token: 0x06026C2C RID: 158764 RVA: 0x003B2158 File Offset: 0x003B0358
		[NullableContext(2)]
		public FStreamlineVersion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026C2D RID: 158765 RVA: 0x003B2162 File Offset: 0x003B0362
		public FStreamlineVersion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026C2E RID: 158766 RVA: 0x003B216D File Offset: 0x003B036D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamlineVersion(Pointer, false, true);
		}

		// Token: 0x06026C2F RID: 158767 RVA: 0x003B2177 File Offset: 0x003B0377
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamlineVersion(Pointer, MemoryOwner);
		}

		// Token: 0x04015462 RID: 87138
		[Nullable(1)]
		public const string __ObjectPath = "/Script/StreamlineBlueprint.StreamlineVersion";

		// Token: 0x04015463 RID: 87139
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015464 RID: 87140
		internal static int __PropertyOffset_Major;

		// Token: 0x04015465 RID: 87141
		internal static int __PropertyOffset_Minor;

		// Token: 0x04015466 RID: 87142
		internal static int __PropertyOffset_Build;
	}
}
