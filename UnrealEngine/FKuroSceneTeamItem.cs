using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001908 RID: 6408
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroSceneTeamItem")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FKuroSceneTeamItem : IEqualityOperators<FKuroSceneTeamItem, FKuroSceneTeamItem, bool>, IEquatable<FKuroSceneTeamItem>, IUnrealScriptStruct
	{
		// Token: 0x06017C78 RID: 97400 RVA: 0x0022D66A File Offset: 0x0022B86A
		public FKuroSceneTeamItem(int EntityId, bool IsMyRole)
		{
			this.EntityId = EntityId;
			this.IsMyRole = IsMyRole;
		}

		// Token: 0x06017C79 RID: 97401 RVA: 0x0022D67A File Offset: 0x0022B87A
		public static bool operator ==(FKuroSceneTeamItem left, FKuroSceneTeamItem right)
		{
			return left.EntityId == right.EntityId && left.IsMyRole == right.IsMyRole;
		}

		// Token: 0x06017C7A RID: 97402 RVA: 0x0022D69A File Offset: 0x0022B89A
		public static bool operator !=(FKuroSceneTeamItem left, FKuroSceneTeamItem right)
		{
			return !(left == right);
		}

		// Token: 0x06017C7B RID: 97403 RVA: 0x0022D6A6 File Offset: 0x0022B8A6
		public bool Equals(FKuroSceneTeamItem other)
		{
			return this == other;
		}

		// Token: 0x06017C7C RID: 97404 RVA: 0x0022D6B4 File Offset: 0x0022B8B4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FKuroSceneTeamItem)
			{
				FKuroSceneTeamItem other = (FKuroSceneTeamItem)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06017C7D RID: 97405 RVA: 0x0022D6D9 File Offset: 0x0022B8D9
		public override int GetHashCode()
		{
			return HashCode.Combine<int, bool>(this.EntityId, this.IsMyRole);
		}

		// Token: 0x06017C7E RID: 97406 RVA: 0x0022D6EC File Offset: 0x0022B8EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSceneTeamItem._ScriptStructPtr != 0) ? FKuroSceneTeamItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroSceneTeamItem", ref FKuroSceneTeamItem._ScriptStructPtr);
		}

		// Token: 0x0400CE5E RID: 52830
		[FieldOffset(0)]
		public int EntityId;

		// Token: 0x0400CE5F RID: 52831
		[FieldOffset(4)]
		public bool IsMyRole;

		// Token: 0x0400CE60 RID: 52832
		public const string __ObjectPath = "/Script/KuroGameplay.KuroSceneTeamItem";

		// Token: 0x0400CE61 RID: 52833
		private static IntPtr _ScriptStructPtr;
	}
}
