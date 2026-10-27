using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200105E RID: 4190
	[UnrealObjectPath("/Script/Engine.QuartzTransportTimeStamp")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FQuartzTransportTimeStamp : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE51 RID: 61009 RVA: 0x00161972 File Offset: 0x0015FB72
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQuartzTransportTimeStamp._ScriptStructPtr != 0) ? FQuartzTransportTimeStamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.QuartzTransportTimeStamp", ref FQuartzTransportTimeStamp._ScriptStructPtr);
		}

		// Token: 0x0600EE52 RID: 61010 RVA: 0x00161996 File Offset: 0x0015FB96
		public FQuartzTransportTimeStamp()
		{
		}

		// Token: 0x0600EE53 RID: 61011 RVA: 0x0016199E File Offset: 0x0015FB9E
		protected override IntPtr GetUStructPtr()
		{
			return FQuartzTransportTimeStamp.StaticStruct();
		}

		// Token: 0x0600EE54 RID: 61012 RVA: 0x001619AA File Offset: 0x0015FBAA
		[NullableContext(2)]
		public FQuartzTransportTimeStamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE55 RID: 61013 RVA: 0x001619B4 File Offset: 0x0015FBB4
		public FQuartzTransportTimeStamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE56 RID: 61014 RVA: 0x001619BF File Offset: 0x0015FBBF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQuartzTransportTimeStamp(Pointer, false, true);
		}

		// Token: 0x0600EE57 RID: 61015 RVA: 0x001619C9 File Offset: 0x0015FBC9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQuartzTransportTimeStamp(Pointer, MemoryOwner);
		}

		// Token: 0x04008104 RID: 33028
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.QuartzTransportTimeStamp";

		// Token: 0x04008105 RID: 33029
		private static IntPtr _ScriptStructPtr;
	}
}
