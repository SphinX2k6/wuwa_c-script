using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000FC RID: 252
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/AIModule.AISenseAffiliationFilter")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct FAISenseAffiliationFilter : IEqualityOperators<FAISenseAffiliationFilter, FAISenseAffiliationFilter, bool>, IEquatable<FAISenseAffiliationFilter>, IUnrealScriptStruct
	{
		// Token: 0x06001369 RID: 4969 RVA: 0x0001CA8D File Offset: 0x0001AC8D
		public FAISenseAffiliationFilter(bool bDetectEnemies, bool bDetectNeutrals, bool bDetectFriendlies)
		{
			this.__DummyField0 = (byte)(((bDetectEnemies > false) ? 1 : 0) | (bDetectNeutrals ? 2 : 0) | (bDetectFriendlies ? 4 : 0));
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0001CAAA File Offset: 0x0001ACAA
		public readonly bool bDetectEnemies
		{
			get
			{
				return (this.__DummyField0 & 1) > 0;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0001CAB7 File Offset: 0x0001ACB7
		public readonly bool bDetectNeutrals
		{
			get
			{
				return (this.__DummyField0 & 2) > 0;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
		public readonly bool bDetectFriendlies
		{
			get
			{
				return (this.__DummyField0 & 4) > 0;
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0001CAD1 File Offset: 0x0001ACD1
		public static bool operator ==(FAISenseAffiliationFilter left, FAISenseAffiliationFilter right)
		{
			return left.__DummyField0 == right.__DummyField0;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0001CAE1 File Offset: 0x0001ACE1
		public static bool operator !=(FAISenseAffiliationFilter left, FAISenseAffiliationFilter right)
		{
			return !(left == right);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0001CAED File Offset: 0x0001ACED
		public bool Equals(FAISenseAffiliationFilter other)
		{
			return this == other;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0001CAFC File Offset: 0x0001ACFC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FAISenseAffiliationFilter)
			{
				FAISenseAffiliationFilter other = (FAISenseAffiliationFilter)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0001CB21 File Offset: 0x0001AD21
		public override int GetHashCode()
		{
			return HashCode.Combine<byte>(this.__DummyField0);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0001CB2E File Offset: 0x0001AD2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAISenseAffiliationFilter._ScriptStructPtr != 0) ? FAISenseAffiliationFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AISenseAffiliationFilter", ref FAISenseAffiliationFilter._ScriptStructPtr);
		}

		// Token: 0x0400038D RID: 909
		[FieldOffset(0)]
		private byte __DummyField0;

		// Token: 0x0400038E RID: 910
		public const string __ObjectPath = "/Script/AIModule.AISenseAffiliationFilter";

		// Token: 0x0400038F RID: 911
		private static IntPtr _ScriptStructPtr;
	}
}
