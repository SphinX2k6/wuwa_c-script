using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200034F RID: 847
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleChunkParameters")]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FDestructibleChunkParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002EF9 RID: 12025 RVA: 0x00047E5E File Offset: 0x0004605E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleChunkParameters._ScriptStructPtr != 0) ? FDestructibleChunkParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleChunkParameters", ref FDestructibleChunkParameters._ScriptStructPtr);
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x00047E82 File Offset: 0x00046082
		// (set) Token: 0x06002EFB RID: 12027 RVA: 0x00047E92 File Offset: 0x00046092
		public unsafe bool bIsSupportChunk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bIsSupportChunk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bIsSupportChunk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x00047EA3 File Offset: 0x000460A3
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x00047EB3 File Offset: 0x000460B3
		public unsafe bool bDoNotFracture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bDoNotFracture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bDoNotFracture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x00047EC4 File Offset: 0x000460C4
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x00047ED4 File Offset: 0x000460D4
		public unsafe bool bDoNotDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bDoNotDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bDoNotDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x00047EE5 File Offset: 0x000460E5
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x00047EF5 File Offset: 0x000460F5
		public unsafe bool bDoNotCrumble
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bDoNotCrumble) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleChunkParameters.__PropertyOffset_bDoNotCrumble) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x00047F06 File Offset: 0x00046106
		public FDestructibleChunkParameters()
		{
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00047F0E File Offset: 0x0004610E
		public FDestructibleChunkParameters(bool bIsSupportChunk, bool bDoNotFracture, bool bDoNotDamage, bool bDoNotCrumble)
		{
			this.bIsSupportChunk = bIsSupportChunk;
			this.bDoNotFracture = bDoNotFracture;
			this.bDoNotDamage = bDoNotDamage;
			this.bDoNotCrumble = bDoNotCrumble;
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x00047F33 File Offset: 0x00046133
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleChunkParameters.StaticStruct();
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x00047F3F File Offset: 0x0004613F
		[NullableContext(2)]
		public FDestructibleChunkParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00047F49 File Offset: 0x00046149
		public FDestructibleChunkParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00047F54 File Offset: 0x00046154
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleChunkParameters(Pointer, false, true);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00047F5E File Offset: 0x0004615E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleChunkParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400143C RID: 5180
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleChunkParameters";

		// Token: 0x0400143D RID: 5181
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400143E RID: 5182
		internal static int __PropertyOffset_bIsSupportChunk;

		// Token: 0x0400143F RID: 5183
		internal static int __PropertyOffset_bDoNotFracture;

		// Token: 0x04001440 RID: 5184
		internal static int __PropertyOffset_bDoNotDamage;

		// Token: 0x04001441 RID: 5185
		internal static int __PropertyOffset_bDoNotCrumble;
	}
}
